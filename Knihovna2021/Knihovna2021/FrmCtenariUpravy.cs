using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Knihovna2021
{
 public partial class FrmCtenariUpravy : Form
 {
  public Ctenar Ctenar { get; set; }

  public FrmCtenariUpravy(Ctenar ctenar)
  {
   InitializeComponent();
   Ctenar = ctenar;
  }

  private void FrmCtenariUpravy_Load(object sender, EventArgs e)
  {
   txtJmeno.Text = Ctenar.Jmeno;
   txtPrijmeni.Text = Ctenar.Prijmeni;
   dtpDatNar.Value = Ctenar.DatumNarozeni;
  }

  private void btnStorno_Click(object sender, EventArgs e)
  {
   DialogResult = DialogResult.Cancel;
   Close();
  }

  private void btnUlozit_Click(object sender, EventArgs e)
  {
   Ctenar.Jmeno = txtJmeno.Text;
   Ctenar.Prijmeni = txtPrijmeni.Text;
   Ctenar.DatumNarozeni = dtpDatNar.Value;
   DialogResult = DialogResult.OK;
  }
 }
}
