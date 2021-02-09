using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Knihovna2021
{
 public class Ctenar
 {
  public int Id { get; set; }
  public string Jmeno { get; set; }
  public string Prijmeni { get; set; }
  public DateTime DatumNarozeni { get; set; }

  public Ctenar(string jmeno, string prijmeni, DateTime datumNarozeni)
  {
   Jmeno = jmeno;
   Prijmeni = prijmeni;
   DatumNarozeni = datumNarozeni;
  }

  public Ctenar(int id, string jmeno, string prijmeni, DateTime datumNarozeni)
  {
   Id = id;
   Jmeno = jmeno;
   Prijmeni = prijmeni;
   DatumNarozeni = datumNarozeni;
  }

  public ListViewItem GetListViewItem()
  {
   return new ListViewItem(new string[] { Id.ToString(), Jmeno, Prijmeni, DatumNarozeni.ToString("dd.MM.yyyy") });
  }
 }
}
