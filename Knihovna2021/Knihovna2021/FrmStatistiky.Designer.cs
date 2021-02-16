
namespace Knihovna2021
{
 partial class FrmStatistiky
 {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing)
  {
   if (disposing && (components != null))
   {
    components.Dispose();
   }
   base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   this.menuStrip1 = new System.Windows.Forms.MenuStrip();
   this.listView1 = new System.Windows.Forms.ListView();
   this.hIdCtenar = new System.Windows.Forms.ColumnHeader();
   this.hNazev = new System.Windows.Forms.ColumnHeader();
   this.hAutor = new System.Windows.Forms.ColumnHeader();
   this.hPocStran = new System.Windows.Forms.ColumnHeader();
   this.hZanr = new System.Windows.Forms.ColumnHeader();
   this.tsNevypujcene = new System.Windows.Forms.ToolStripMenuItem();
   this.tsNejpucovanejsi = new System.Windows.Forms.ToolStripMenuItem();
   this.tsMinPujcovane = new System.Windows.Forms.ToolStripMenuItem();
   this.tsVypujcene = new System.Windows.Forms.ToolStripMenuItem();
   this.menuStrip1.SuspendLayout();
   this.SuspendLayout();
   // 
   // menuStrip1
   // 
   this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
   this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVypujcene,
            this.tsNevypujcene,
            this.tsNejpucovanejsi,
            this.tsMinPujcovane});
   this.menuStrip1.Location = new System.Drawing.Point(0, 0);
   this.menuStrip1.Name = "menuStrip1";
   this.menuStrip1.Size = new System.Drawing.Size(800, 28);
   this.menuStrip1.TabIndex = 0;
   this.menuStrip1.Text = "menuStrip1";
   // 
   // listView1
   // 
   this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hIdCtenar,
            this.hNazev,
            this.hAutor,
            this.hPocStran,
            this.hZanr});
   this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
   this.listView1.FullRowSelect = true;
   this.listView1.GridLines = true;
   this.listView1.HideSelection = false;
   this.listView1.Location = new System.Drawing.Point(0, 28);
   this.listView1.MultiSelect = false;
   this.listView1.Name = "listView1";
   this.listView1.Size = new System.Drawing.Size(800, 422);
   this.listView1.TabIndex = 4;
   this.listView1.UseCompatibleStateImageBehavior = false;
   this.listView1.View = System.Windows.Forms.View.Details;
   // 
   // hIdCtenar
   // 
   this.hIdCtenar.Text = "Id";
   // 
   // hNazev
   // 
   this.hNazev.Text = "Název";
   // 
   // hAutor
   // 
   this.hAutor.Text = "Autor";
   // 
   // hPocStran
   // 
   this.hPocStran.Text = "Počet stran";
   // 
   // hZanr
   // 
   this.hZanr.Text = "Žánr";
   // 
   // tsNevypujcene
   // 
   this.tsNevypujcene.Name = "tsNevypujcene";
   this.tsNevypujcene.Size = new System.Drawing.Size(146, 24);
   this.tsNevypujcene.Text = "Nevypůjčené knihy";
   this.tsNevypujcene.Click += new System.EventHandler(this.tsNevypujcene_Click);
   // 
   // tsNejpucovanejsi
   // 
   this.tsNejpucovanejsi.Name = "tsNejpucovanejsi";
   this.tsNejpucovanejsi.Size = new System.Drawing.Size(160, 24);
   this.tsNejpucovanejsi.Text = "Nejčastěji půjčované";
   this.tsNejpucovanejsi.Click += new System.EventHandler(this.tsNejpucovanejsi_Click);
   // 
   // tsMinPujcovane
   // 
   this.tsMinPujcovane.Name = "tsMinPujcovane";
   this.tsMinPujcovane.Size = new System.Drawing.Size(155, 24);
   this.tsMinPujcovane.Text = "Nejméně půjčované";
   this.tsMinPujcovane.Click += new System.EventHandler(this.tsMinPujcovane_Click);
   // 
   // tsVypujcene
   // 
   this.tsVypujcene.Name = "tsVypujcene";
   this.tsVypujcene.Size = new System.Drawing.Size(129, 24);
   this.tsVypujcene.Text = "Vypůjčené knihy";
   this.tsVypujcene.Click += new System.EventHandler(this.tsVypujcene_Click);
   // 
   // FrmStatistiky
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(800, 450);
   this.Controls.Add(this.listView1);
   this.Controls.Add(this.menuStrip1);
   this.MainMenuStrip = this.menuStrip1;
   this.Name = "FrmStatistiky";
   this.Text = "Statistiky";
   this.menuStrip1.ResumeLayout(false);
   this.menuStrip1.PerformLayout();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.MenuStrip menuStrip1;
  private System.Windows.Forms.ToolStripMenuItem tsVypujcene;
  private System.Windows.Forms.ToolStripMenuItem tsNevypujcene;
  private System.Windows.Forms.ToolStripMenuItem tsNejpucovanejsi;
  private System.Windows.Forms.ToolStripMenuItem tsMinPujcovane;
  private System.Windows.Forms.ListView listView1;
  private System.Windows.Forms.ColumnHeader hIdCtenar;
  private System.Windows.Forms.ColumnHeader hNazev;
  private System.Windows.Forms.ColumnHeader hAutor;
  private System.Windows.Forms.ColumnHeader hPocStran;
  private System.Windows.Forms.ColumnHeader hZanr;
 }
}