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

  public List<Ctenar> NactiCtenare()
  {
   List<Ctenar> ctenari = new List<Ctenar>();
   using(SqlConnection sqlConnection = new SqlConnection(ConnectionString))
   {
    using(SqlCommand sqlCommand = new SqlCommand("select * from Ctenari", sqlConnection))
    {
     sqlConnection.Open();
     using(SqlDataReader dataReader = sqlCommand.ExecuteReader())
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
 }
}
