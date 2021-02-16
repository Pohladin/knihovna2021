using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Knihovna2021
{
 public partial class FrmKnihyUpravy : Form
 {
  public Kniha Kniha { get; set; }

  public FrmKnihyUpravy(Kniha kniha)
  {
   InitializeComponent();
   Kniha = kniha;
  }

  private void FrmKnihyUpravy_Load(object sender, EventArgs e)
  {
   txtNazev.Text = Kniha.Nazev;
   txtAutor.Text = Kniha.Autor;
   numPocetStran.Value = Kniha.PocetStran;
   txtZanr.Text = Kniha.Zanr;
  }

  private void btnStorno_Click(object sender, EventArgs e)
  {
   DialogResult = DialogResult.Cancel;
   Close();
  }

  private void btnUlozit_Click(object sender, EventArgs e)
  {
   Kniha.Nazev = txtNazev.Text;
   Kniha.Autor = txtAutor.Text;
   Kniha.PocetStran = Convert.ToInt32(numPocetStran.Value);
   Kniha.Zanr = txtZanr.Text;
   DialogResult = DialogResult.OK;
  }
 }
}
