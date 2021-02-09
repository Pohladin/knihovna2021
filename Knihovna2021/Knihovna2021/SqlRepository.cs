using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Knihovna2021
{
 public class SqlRepository
 {
  public string ConnectionString { get; set; }

  public SqlRepository(string connectionString)
  {
   ConnectionString = connectionString;
  }

  public List<Ctenar> NactiCtenare(string sloupecTrideni, bool sestupne, string hledani)
  {
   List<Ctenar> ctenari = new List<Ctenar>();
   using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
    {
     sqlCommand.CommandText = $"select * from Ctenari where jmeno like @Hledani or prijmeni like @Hledani order by {sloupecTrideni}{(sestupne ? " desc" : "")}";
     sqlCommand.Parameters.AddWithValue("Hledani", "%"+hledani+"%");
     sqlConnection.Open();
     using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
     {
      while (dataReader.Read())
      {
       ctenari.Add(new Ctenar(Convert.ToInt32(dataReader["IdCtenari"]),
                              dataReader["Jmeno"].ToString(),
                              dataReader["Prijmeni"].ToString(),
                              Convert.ToDateTime(dataReader["DatumNarozeni"])));
      }
     }
     sqlConnection.Close();
    }
   }
   return ctenari;
  }

  public void UlozCtenare(Ctenar ctenar)
  {
   if (ctenar.Id == 0)
   {
    // není v databázi -> budeme ho vytvářet
    using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
    {
     using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
     {
      sqlCommand.CommandText = "insert into Ctenari(Jmeno,Prijmeni,DatumNarozeni) values(@Jmeno,@Prijmeni,@DatumNarozeni)";
      sqlCommand.Parameters.AddWithValue("Jmeno", ctenar.Jmeno);
      sqlCommand.Parameters.AddWithValue("Prijmeni", ctenar.Prijmeni);
      sqlCommand.Parameters.AddWithValue("DatumNarozeni", ctenar.DatumNarozeni);
      sqlConnection.Open();
      sqlCommand.ExecuteNonQuery();
      sqlConnection.Close();
     }
    }
   }
   else
   {
    //pouze update
    using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
    {
     using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
     {
      sqlCommand.CommandText = $"update Ctenari set Jmeno=@Jmeno ,Prijmeni=@Prijmeni,DatumNarozeni=@DatumNarozeni where IdCtenari={ctenar.Id}";
      sqlCommand.Parameters.AddWithValue("Jmeno", ctenar.Jmeno);
      sqlCommand.Parameters.AddWithValue("Prijmeni", ctenar.Prijmeni);
      sqlCommand.Parameters.AddWithValue("DatumNarozeni", ctenar.DatumNarozeni);
      sqlConnection.Open();
      sqlCommand.ExecuteNonQuery();
      sqlConnection.Close();
     }
    }
   }
  }

  public void SmazCtenare(Ctenar ctenar)
  {
   using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
    {
     sqlCommand.CommandText = $"delete from Ctenari where IdCtenari={ctenar.Id}"; 
     sqlConnection.Open();
     sqlCommand.ExecuteNonQuery();
     sqlConnection.Close();
    }
   }
  }
 }
}
