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

  public List<Kniha> NactiKnihy(string sloupecTrideni, bool sestupne, string hledani)
  {
   List<Kniha> knihy = new List<Kniha>();
   using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
    {
     sqlCommand.CommandText = $"select * from Knihy where Nazev like @Hledani order by {sloupecTrideni}{(sestupne ? " desc" : "")}";
     sqlCommand.Parameters.AddWithValue("Hledani", "%" + hledani + "%");
     sqlConnection.Open();
     using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
     {
      while (dataReader.Read())
      {
       knihy.Add(new Kniha(Convert.ToInt32(dataReader["IdKnihy"]),
                              dataReader["Nazev"].ToString(),
                              dataReader["Autor"].ToString(),
                              Convert.ToInt32(dataReader["PocetStran"]),
                              dataReader["Zanr"].ToString()));
      }
     }
     sqlConnection.Close();
    }
   }
   return knihy;
  }

  public List<Kniha> NactiKnihyNevypujcene()
  {
   List<Kniha> knihy = new List<Kniha>();
   using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
    {
     sqlCommand.CommandText = $"select * from Knihy where IdKnihy not in (select k.IdKnihy from Vypujcky v join Knihy k on v.IdKnihy=k.IdKnihy where v.DatumVraceni is null)";
     sqlConnection.Open();
     using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
     {
      while (dataReader.Read())
      {
       knihy.Add(new Kniha(Convert.ToInt32(dataReader["IdKnihy"]),
                              dataReader["Nazev"].ToString(),
                              dataReader["Autor"].ToString(),
                              Convert.ToInt32(dataReader["PocetStran"]),
                              dataReader["Zanr"].ToString()));
      }
     }
     sqlConnection.Close();
    }
   }
   return knihy;
  }

  public List<Kniha> NactiKnihyVypujcene(Ctenar ctenar)
  {
   List<Kniha> knihy = new List<Kniha>();
   using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
    {
     sqlCommand.CommandText = $"select k.* from Vypujcky v join Knihy k on v.IdKnihy=k.IdKnihy join Ctenari c on v.IdCtenari=c.IdCtenari where v.DatumVraceni is null and c.IdCtenari={ctenar.Id}";
     sqlConnection.Open();
     using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
     {
      while (dataReader.Read())
      {
       knihy.Add(new Kniha(Convert.ToInt32(dataReader["IdKnihy"]),
                              dataReader["Nazev"].ToString(),
                              dataReader["Autor"].ToString(),
                              Convert.ToInt32(dataReader["PocetStran"]),
                              dataReader["Zanr"].ToString()));
      }
     }
     sqlConnection.Close();
    }
   }
   return knihy;
  }

  public List<Kniha> NactiKnihyVypujcene()
  {
   List<Kniha> knihy = new List<Kniha>();
   using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
    {
     sqlCommand.CommandText = $"select k.* from Vypujcky v join Knihy k on v.IdKnihy=k.IdKnihy where v.DatumVraceni is null";
     sqlConnection.Open();
     using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
     {
      while (dataReader.Read())
      {
       knihy.Add(new Kniha(Convert.ToInt32(dataReader["IdKnihy"]),
                              dataReader["Nazev"].ToString(),
                              dataReader["Autor"].ToString(),
                              Convert.ToInt32(dataReader["PocetStran"]),
                              dataReader["Zanr"].ToString()));
      }
     }
     sqlConnection.Close();
    }
   }
   return knihy;
  }

  public void UlozKnihu(Kniha kniha)
  {
   if (kniha.Id == 0)
   {
    // není v databázi -> budeme ho vytvářet
    using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
    {
     using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
     {
      sqlCommand.CommandText = $"insert into Knihy(Nazev,Autor,PocetStran,Zanr) values(@Nazev,@Autor,{kniha.PocetStran},@Zanr)";
      sqlCommand.Parameters.AddWithValue("Nazev", kniha.Nazev);
      sqlCommand.Parameters.AddWithValue("Autor", kniha.Autor);
      sqlCommand.Parameters.AddWithValue("Zanr", kniha.Zanr);
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
      sqlCommand.CommandText = $"update Knihy set Nazev=@Nazev ,Autor=@Autor,PocetStran={kniha.PocetStran},Zanr=@Zanr where IdKnihy={kniha.Id}";
      sqlCommand.Parameters.AddWithValue("Nazev", kniha.Nazev);
      sqlCommand.Parameters.AddWithValue("Autor", kniha.Autor);
      sqlCommand.Parameters.AddWithValue("Zanr", kniha.Zanr);
      sqlConnection.Open();
      sqlCommand.ExecuteNonQuery();
      sqlConnection.Close();
     }
    }
   }
  }

  public void SmazKnihu(Kniha kniha)
  {
   using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
    {
     sqlCommand.CommandText = $"delete from Knihy where IdKnihy={kniha.Id}";
     sqlConnection.Open();
     sqlCommand.ExecuteNonQuery();
     sqlConnection.Close();
    }
   }
  }

  public void VypujcKnihu(Ctenar ctenar, Kniha kniha)
  {
   using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
    {
     sqlCommand.CommandText = $"insert into Vypujcky(IdCtenari,IdKnihy,DatumVypujceni) values({ctenar.Id},{kniha.Id},getdate())";
     sqlConnection.Open();
     sqlCommand.ExecuteNonQuery();
     sqlConnection.Close();
    }
   }
  }
    
  public void VratKnihu(Ctenar ctenar, Kniha kniha)
  {
   using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
    {
     sqlCommand.CommandText = $"update Vypujcky set DatumVraceni=getdate() where IdCtenari={ctenar.Id} and IdKnihy={kniha.Id} and DatumVraceni is null";
     sqlConnection.Open();
     sqlCommand.ExecuteNonQuery();
     sqlConnection.Close();
    }
   }
  }

  public void StornoVypujcky(Ctenar ctenar, Kniha kniha)
  {
   using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
   {
    using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
    {
     sqlCommand.CommandText = $"delete from Vypujcky where IdCtenari={ctenar.Id} and IdKnihy={kniha.Id} and DatumVraceni is null";
     sqlConnection.Open();
     sqlCommand.ExecuteNonQuery();
     sqlConnection.Close();
    }
   }
  }

 }
}
