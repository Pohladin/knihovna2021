using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Knihovna2021
{
 public partial class FrmCtenari : Form
 {
  private List<Ctenar> ctenari;
  private SqlRepository sqlRepository;
  private string[] sloupce = new string[] { "IdCtenari", "Jmeno", "Prijmeni", "DatumNarozeni" };
  private int sloupecTrideni = 0;
  private bool sestupne;

  public FrmCtenari()
  {
   InitializeComponent();
   sqlRepository = new SqlRepository("Data Source=titanic.vassboskovice.cz;Initial Catalog=Hla_knihovna_2021;User ID=sa;Password=Agent007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
  }

  private void FrmCtenari_Load(object sender, EventArgs e)
  {
   ZobrazData();
  }

  private void tsPridat_Click(object sender, EventArgs e)
  {
   FrmCtenariUpravy frmCtenariUpravy = new FrmCtenariUpravy(new Ctenar("", "", DateTime.Now));
   if (frmCtenariUpravy.ShowDialog() == DialogResult.OK)
   {
    sqlRepository.UlozCtenare(frmCtenariUpravy.Ctenar);
    //ctenari.Add(frmCtenariUpravy.Ctenar);
    ZobrazData();
   }
  }

  private void tsUpravit_Click(object sender, EventArgs e)
  {
   if (listView1.SelectedIndices.Count > 0)
   {
    FrmCtenariUpravy frmCtenariUpravy = new FrmCtenariUpravy(ctenari[listView1.SelectedIndices[0]]);
    if (frmCtenariUpravy.ShowDialog() == DialogResult.OK)
    {
     sqlRepository.UlozCtenare(frmCtenariUpravy.Ctenar);
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
   ctenari = sqlRepository.NactiCtenare(sloupce[sloupecTrideni], sestupne, tsHledat.Text);
   listView1.Items.Clear();
   foreach (var ctenar in ctenari)
   {
    listView1.Items.Add(ctenar.GetListViewItem());
   }
  }

  private void tsSmazat_Click(object sender, EventArgs e)
  {
   if (listView1.SelectedIndices.Count > 0)
   {
    try
    {
     sqlRepository.SmazCtenare(ctenari[listView1.SelectedIndices[0]]);
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
   //switch (e.Column)
   //{
   // case 0:
   //  this.Text = "IdCtenari";
   //  break;
   // case 1:
   //  this.Text = "Jmeno";
   //  break;
   // case 2:
   //  this.Text = "Prijmeni";
   //  break;
   // case 3:
   //  this.Text = "DatumNarozeni";
   //  break;
   //}
  }

  private void tsHledat_TextChanged(object sender, EventArgs e)
  {
   ZobrazData();
  }

  private void tsSpravaVypujcek_Click(object sender, EventArgs e)
  {
   if (listView1.SelectedIndices.Count > 0)
   {
    FrmVypujcky frmVypujcky = new FrmVypujcky(ctenari[listView1.SelectedIndices[0]]);
    frmVypujcky.ShowDialog();
   }
  }
 }
}
