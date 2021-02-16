using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Knihovna2021
{
 public partial class FrmStatistiky : Form
 {
  private List<Kniha> knihy;
  private SqlRepository sqlRepository;

  public FrmStatistiky()
  {
   InitializeComponent();
   knihy = new List<Kniha>();
   sqlRepository = new SqlRepository("Data Source=titanic.vassboskovice.cz;Initial Catalog=Hla_knihovna_2021;User ID=sa;Password=Agent007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
  }

  private void tsMinPujcovane_Click(object sender, EventArgs e)
  {

  }

  private void tsNejpucovanejsi_Click(object sender, EventArgs e)
  {

  }

  private void tsNevypujcene_Click(object sender, EventArgs e)
  {
   knihy = sqlRepository.NactiKnihyNevypujcene();
   listView1.Items.Clear();
   foreach(var kniha in knihy)
   {
    listView1.Items.Add(kniha.GetListViewItem());
   }
  }

  private void tsVypujcene_Click(object sender, EventArgs e)
  {
   knihy = sqlRepository.NactiKnihyVypujcene();
   listView1.Items.Clear();
   foreach (var kniha in knihy)
   {
    listView1.Items.Add(kniha.GetListViewItem());
   }
  }
 }
}
