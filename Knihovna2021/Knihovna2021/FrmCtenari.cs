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

  public FrmCtenari()
  {
   InitializeComponent();
   sqlRepository = new SqlRepository("Data Source=titanic.vassboskovice.cz;Initial Catalog=Hla_knihovna_2021;User ID=sa;Password=Agent007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
  }

  private void FrmCtenari_Load(object sender, EventArgs e)
  {
   ctenari = sqlRepository.NactiCtenare();
   foreach (var ctenar in ctenari)
   {
    listView1.Items.Add(ctenar.GetListViewItem());
   }
  }

  private void tsPridat_Click(object sender, EventArgs e)
  {
   FrmCtenariUpravy frmCtenariUpravy = new FrmCtenariUpravy(new Ctenar("", "", DateTime.Now));
   if (frmCtenariUpravy.ShowDialog() == DialogResult.OK)
   {
    ctenari.Add(frmCtenariUpravy.Ctenar);
    listView1.Items.Clear();
    foreach (var ctenar in ctenari)
    {
     listView1.Items.Add(ctenar.GetListViewItem());
    }
   }
  }

  private void tsUpravit_Click(object sender, EventArgs e)
  {
   if (listView1.SelectedIndices.Count > 0)
   {
    FrmCtenariUpravy frmCtenariUpravy = new FrmCtenariUpravy(ctenari[listView1.SelectedIndices[0]]);
    if (frmCtenariUpravy.ShowDialog() == DialogResult.OK)
    {
     listView1.Items.Clear();
     foreach (var ctenar in ctenari)
     {
      listView1.Items.Add(ctenar.GetListViewItem());
     }
    }
   }
  }
 }
}
