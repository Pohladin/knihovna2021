﻿
namespace Knihovna2021
{
 partial class FrmKnihy
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
   this.listView1 = new System.Windows.Forms.ListView();
   this.hIdCtenar = new System.Windows.Forms.ColumnHeader();
   this.hNazev = new System.Windows.Forms.ColumnHeader();
   this.hAutor = new System.Windows.Forms.ColumnHeader();
   this.hPocStran = new System.Windows.Forms.ColumnHeader();
   this.hZanr = new System.Windows.Forms.ColumnHeader();
   this.menuStrip1 = new System.Windows.Forms.MenuStrip();
   this.tsPridat = new System.Windows.Forms.ToolStripMenuItem();
   this.tsUpravit = new System.Windows.Forms.ToolStripMenuItem();
   this.tsSmazat = new System.Windows.Forms.ToolStripMenuItem();
   this.tsHledat = new System.Windows.Forms.ToolStripTextBox();
   this.menuStrip1.SuspendLayout();
   this.SuspendLayout();
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
   this.listView1.Location = new System.Drawing.Point(0, 27);
   this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
   this.listView1.MultiSelect = false;
   this.listView1.Name = "listView1";
   this.listView1.Size = new System.Drawing.Size(700, 311);
   this.listView1.TabIndex = 3;
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
   // menuStrip1
   // 
   this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
   this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPridat,
            this.tsUpravit,
            this.tsSmazat,
            this.tsHledat});
   this.menuStrip1.Location = new System.Drawing.Point(0, 0);
   this.menuStrip1.Name = "menuStrip1";
   this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
   this.menuStrip1.Size = new System.Drawing.Size(700, 27);
   this.menuStrip1.TabIndex = 2;
   this.menuStrip1.Text = "menuStrip1";
   // 
   // tsPridat
   // 
   this.tsPridat.Name = "tsPridat";
   this.tsPridat.Size = new System.Drawing.Size(50, 23);
   this.tsPridat.Text = "Přidat";
   this.tsPridat.Click += new System.EventHandler(this.tsPridat_Click);
   // 
   // tsUpravit
   // 
   this.tsUpravit.Name = "tsUpravit";
   this.tsUpravit.Size = new System.Drawing.Size(57, 23);
   this.tsUpravit.Text = "Upravit";
   this.tsUpravit.Click += new System.EventHandler(this.tsUpravit_Click);
   // 
   // tsSmazat
   // 
   this.tsSmazat.Name = "tsSmazat";
   this.tsSmazat.Size = new System.Drawing.Size(57, 23);
   this.tsSmazat.Text = "Smazat";
   this.tsSmazat.Click += new System.EventHandler(this.tsSmazat_Click);
   // 
   // tsHledat
   // 
   this.tsHledat.Name = "tsHledat";
   this.tsHledat.Size = new System.Drawing.Size(88, 23);
   this.tsHledat.TextChanged += new System.EventHandler(this.tsHledat_TextChanged);
   // 
   // FrmKnihy
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(700, 338);
   this.Controls.Add(this.listView1);
   this.Controls.Add(this.menuStrip1);
   this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
   this.Name = "FrmKnihy";
   this.Text = "Knihy";
   this.Load += new System.EventHandler(this.FrmKnihy_Load);
   this.menuStrip1.ResumeLayout(false);
   this.menuStrip1.PerformLayout();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.ListView listView1;
  private System.Windows.Forms.ColumnHeader hIdCtenar;
  private System.Windows.Forms.ColumnHeader hNazev;
  private System.Windows.Forms.ColumnHeader hAutor;
  private System.Windows.Forms.ColumnHeader hPocStran;
  private System.Windows.Forms.ColumnHeader hZanr;
  private System.Windows.Forms.MenuStrip menuStrip1;
  private System.Windows.Forms.ToolStripMenuItem tsPridat;
  private System.Windows.Forms.ToolStripMenuItem tsUpravit;
  private System.Windows.Forms.ToolStripMenuItem tsSmazat;
  private System.Windows.Forms.ToolStripTextBox tsHledat;
 }
}