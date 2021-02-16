using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Knihovna2021
{
 public partial class FrmKnihy : Form
 {
  private List<Kniha> knihy;
  private SqlRepository sqlRepository;
  private string[] sloupce = new string[] { "IdKnihy", "Nazev", "Autor", "PocetStran", "Zanr" };
  private int sloupecTrideni = 0;
  private bool sestupne;

  public FrmKnihy()
  {
   InitializeComponent();
   sqlRepository = new SqlRepository("Data Source=titanic.vassboskovice.cz;Initial Catalog=Hla_knihovna_2021;User ID=sa;Password=Agent007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
  }

  private void tsPridat_Click(object sender, EventArgs e)
  {
   FrmKnihyUpravy frmKnihyUpravy  = new FrmKnihyUpravy(new Kniha("", "", 0, ""));
   if (frmKnihyUpravy.ShowDialog() == DialogResult.OK)
   {
    sqlRepository.UlozKnihu(frmKnihyUpravy.Kniha);
    //ctenari.Add(frmCtenariUpravy.Ctenar);
    ZobrazData();
   }
  }

  private void tsUpravit_Click(object sender, EventArgs e)
  {
   if (listView1.SelectedIndices.Count > 0)
   {
    FrmKnihyUpravy frmKnihyUpravy = new FrmKnihyUpravy(knihy[listView1.SelectedIndices[0]]);
    if (frmKnihyUpravy.ShowDialog() == DialogResult.OK)
    {
     sqlRepository.UlozKnihu(frmKnihyUpravy.Kniha);
     ZobrazData();
    }
   }
   else
   {
    MessageBox.Show("Vyberte záznam");
   }
  }

  private void ZobrazData()
  {
   knihy = sqlRepository.NactiKnihy(sloupce[sloupecTrideni], sestupne, tsHledat.Text);
   listView1.Items.Clear();
   foreach (var kniha in knihy)
   {
    listView1.Items.Add(kniha.GetListViewItem());
   }
  }

  private void tsSmazat_Click(object sender, EventArgs e)
  {
   if (listView1.SelectedIndices.Count > 0)
   {
    try
    {
     sqlRepository.SmazKnihu(knihy[listView1.SelectedIndices[0]]);
     ZobrazData();
    }
    catch
    {
     MessageBox.Show("Záznam nelze smazat");
    }
   }
   else
   {
    MessageBox.Show("Vyberte záznam");
   }
  }

  private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
  {
   if (e.Column == sloupecTrideni)
   {
    sestupne = !sestupne;
   }
   sloupecTrideni = e.Column;
   ZobrazData();  
  }

  private void tsHledat_TextChanged(object sender, EventArgs e)
  {
   ZobrazData();
  }

  private void FrmKnihy_Load(object sender, EventArgs e)
  {
ZobrazData();
  }
 }
}
