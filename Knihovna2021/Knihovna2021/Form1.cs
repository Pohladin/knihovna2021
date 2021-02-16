using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knihovna2021
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void btnCtenari_Click(object sender, EventArgs e)
  {
   FrmCtenari frmCtenari = new FrmCtenari();
   frmCtenari.ShowDialog();
  }

  private void btnKnihy_Click(object sender, EventArgs e)
  {
   FrmKnihy frmKnihy = new FrmKnihy();
   frmKnihy.ShowDialog();
  }

  private void btnVypujcky_Click(object sender, EventArgs e)
  {
   //FrmVypujcky frmVypujcky = new FrmVypujcky();
   //frmVypujcky.ShowDialog();
  }

  private void btnStatistiky_Click(object sender, EventArgs e)
  {
   FrmStatistiky frmStatistiky = new FrmStatistiky();
   frmStatistiky.ShowDialog();
  }
 }
}
