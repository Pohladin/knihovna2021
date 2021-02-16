using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Knihovna2021
{
 public partial class FrmVypujcky : Form
 {
  private SqlRepository sqlRepository;
  private List<Kniha> nevypujceneKnihy;
  private List<Kniha> vypujceneKnihy;

  public Ctenar Ctenar { get; set; }

  public FrmVypujcky(Ctenar ctenar)
  {
   InitializeComponent();
   Ctenar = ctenar;
   sqlRepository = new SqlRepository("Data Source=titanic.vassboskovice.cz;Initial Catalog=Hla_knihovna_2021;User ID=sa;Password=Agent007;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
   nevypujceneKnihy = new List<Kniha>();
  }

  private void FrmVypujcky_Load(object sender, EventArgs e)
  {
   lblCtenar.Text = Ctenar.Jmeno + " " + Ctenar.Prijmeni;
   ZobrazData();
  }

  private void ZobrazData()
  {
   ZobrazNevypujceneKnihy();
   ZobrazVypujceneKnihy();
  }

  private void ZobrazNevypujceneKnihy()
  {
   nevypujceneKnihy = sqlRepository.NactiKnihyNevypujcene();
   lvKnihovna.Items.Clear();
   foreach(var kniha in nevypujceneKnihy)
   {
    lvKnihovna.Items.Add(kniha.GetListViewItem());
   }
  }

  private void ZobrazVypujceneKnihy()
  {
   vypujceneKnihy = sqlRepository.NactiKnihyVypujcene(Ctenar);
   lvVypujcene.Items.Clear();
   foreach (var kniha in vypujceneKnihy)
   {
    lvVypujcene.Items.Add(kniha.GetListViewItem());
   }
  }

  private void FrmVypujcky_Resize(object sender, EventArgs e)
  {
   int lvSirka = ClientRectangle.Width / 2 - 100;
   lvKnihovna.Width = lvSirka;
   lvVypujcene.Width = lvSirka;
   btnVratit.Left = lvVypujcene.Right + 25;
   btnVypujcit.Left = btnVratit.Left;
   btnStorno.Left = btnVratit.Left;
  }

  private void btnVypujcit_Click(object sender, EventArgs e)
  {
   if (lvKnihovna.SelectedIndices.Count > 0)
   {
    sqlRepository.VypujcKnihu(Ctenar, nevypujceneKnihy[lvKnihovna.SelectedIndices[0]]);
    ZobrazData();
   }
   else
   {
    MessageBox.Show("Vyberte knihu v knihovně!!!");
   }
  }

  private void btnVratit_Click(object sender, EventArgs e)
  {
   if (lvVypujcene.SelectedIndices.Count > 0)
   {
    sqlRepository.VratKnihu(Ctenar, vypujceneKnihy[lvVypujcene.SelectedIndices[0]]);
    ZobrazData();
   }
   else
   {
    MessageBox.Show("Vyberte knihu, kterou chcete vrátit!!!");
   }
  }

  private void btnStorno_Click(object sender, EventArgs e)
  {
   if (lvVypujcene.SelectedIndices.Count > 0)
   {
    sqlRepository.StornoVypujcky(Ctenar, vypujceneKnihy[lvVypujcene.SelectedIndices[0]]);
    ZobrazData();
   }
   else
   {
    MessageBox.Show("Vyberte knihu, kterou chcete vrátit!!!");
   }
  }

  private void lvKnihovna_DoubleClick(object sender, EventArgs e)
  {
   btnVypujcit.PerformClick();
  }

  private void lvVypujcene_DoubleClick(object sender, EventArgs e)
  {
   btnVratit.PerformClick();
  }
 }
}
