using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Knihovna2021
{
 public class Kniha
 {
  public int Id { get; set; }
  public string Nazev { get; set; }
  public string Autor { get; set; }
  public int PocetStran { get; set; }
  public string Zanr { get; set; }

  public Kniha(string nazev, string autor, int pocetStran, string zanr)
  {
   Nazev = nazev;
   Autor = autor;
   PocetStran = pocetStran;
   Zanr = zanr;
  }

  public Kniha(int id, string nazev, string autor, int pocetStran, string zanr)
  {
   Id = id;
   Nazev = nazev;
   Autor = autor;
   PocetStran = pocetStran;
   Zanr = zanr;
  }

  public ListViewItem GetListViewItem()
  {
   return new ListViewItem(new string[] { Id.ToString(), Nazev, Autor, PocetStran.ToString(),Zanr });
  }
 }
}
