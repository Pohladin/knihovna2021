﻿
namespace Knihovna2021
{
 partial class FrmCtenari
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
   this.tsPridat = new System.Windows.Forms.ToolStripMenuItem();
   this.tsUpravit = new System.Windows.Forms.ToolStripMenuItem();
   this.tsSmazat = new System.Windows.Forms.ToolStripMenuItem();
   this.tsHledat = new System.Windows.Forms.ToolStripTextBox();
   this.listView1 = new System.Windows.Forms.ListView();
   this.hIdCtenar = new System.Windows.Forms.ColumnHeader();
   this.hJmeno = new System.Windows.Forms.ColumnHeader();
   this.hPrijmeni = new System.Windows.Forms.ColumnHeader();
   this.hDatNar = new System.Windows.Forms.ColumnHeader();
   this.tsSpravaVypujcek = new System.Windows.Forms.ToolStripMenuItem();
   this.menuStrip1.SuspendLayout();
   this.SuspendLayout();
   // 
   // menuStrip1
   // 
   this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
   this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPridat,
            this.tsUpravit,
            this.tsSmazat,
            this.tsHledat,
            this.tsSpravaVypujcek});
   this.menuStrip1.Location = new System.Drawing.Point(0, 0);
   this.menuStrip1.Name = "menuStrip1";
   this.menuStrip1.Size = new System.Drawing.Size(921, 31);
   this.menuStrip1.TabIndex = 0;
   this.menuStrip1.Text = "menuStrip1";
   // 
   // tsPridat
   // 
   this.tsPridat.Name = "tsPridat";
   this.tsPridat.Size = new System.Drawing.Size(62, 27);
   this.tsPridat.Text = "Přidat";
   this.tsPridat.Click += new System.EventHandler(this.tsPridat_Click);
   // 
   // tsUpravit
   // 
   this.tsUpravit.Name = "tsUpravit";
   this.tsUpravit.Size = new System.Drawing.Size(71, 27);
   this.tsUpravit.Text = "Upravit";
   this.tsUpravit.Click += new System.EventHandler(this.tsUpravit_Click);
   // 
   // tsSmazat
   // 
   this.tsSmazat.Name = "tsSmazat";
   this.tsSmazat.Size = new System.Drawing.Size(72, 27);
   this.tsSmazat.Text = "Smazat";
   this.tsSmazat.Click += new System.EventHandler(this.tsSmazat_Click);
   // 
   // tsHledat
   // 
   this.tsHledat.Name = "tsHledat";
   this.tsHledat.Size = new System.Drawing.Size(100, 27);
   this.tsHledat.TextChanged += new System.EventHandler(this.tsHledat_TextChanged);
   // 
   // listView1
   // 
   this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hIdCtenar,
            this.hJmeno,
            this.hPrijmeni,
            this.hDatNar});
   this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
   this.listView1.FullRowSelect = true;
   this.listView1.GridLines = true;
   this.listView1.HideSelection = false;
   this.listView1.Location = new System.Drawing.Point(0, 31);
   this.listView1.MultiSelect = false;
   this.listView1.Name = "listView1";
   this.listView1.Size = new System.Drawing.Size(921, 582);
   this.listView1.TabIndex = 1;
   this.listView1.UseCompatibleStateImageBehavior = false;
   this.listView1.View = System.Windows.Forms.View.Details;
   this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
   // 
   // hIdCtenar
   // 
   this.hIdCtenar.Text = "Id";
   // 
   // hJmeno
   // 
   this.hJmeno.Text = "Jméno";
   // 
   // hPrijmeni
   // 
   this.hPrijmeni.Text = "Příjmení";
   // 
   // hDatNar
   // 
   this.hDatNar.Text = "Datum narození";
   // 
   // tsSpravaVypujcek
   // 
   this.tsSpravaVypujcek.Name = "tsSpravaVypujcek";
   this.tsSpravaVypujcek.Size = new System.Drawing.Size(129, 27);
   this.tsSpravaVypujcek.Text = "Správa výpůjček";
   this.tsSpravaVypujcek.Click += new System.EventHandler(this.tsSpravaVypujcek_Click);
   // 
   // FrmCtenari
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(921, 613);
   this.Controls.Add(this.listView1);
   this.Controls.Add(this.menuStrip1);
   this.Name = "FrmCtenari";
   this.Text = "Čtenáři";
   this.Load += new System.EventHandler(this.FrmCtenari_Load);
   this.menuStrip1.ResumeLayout(false);
   this.menuStrip1.PerformLayout();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.MenuStrip menuStrip1;
  private System.Windows.Forms.ToolStripMenuItem tsPridat;
  private System.Windows.Forms.ToolStripMenuItem tsUpravit;
  private System.Windows.Forms.ToolStripMenuItem tsSmazat;
  private System.Windows.Forms.ListView listView1;
  private System.Windows.Forms.ColumnHeader hIdCtenar;
  private System.Windows.Forms.ColumnHeader hJmeno;
  private System.Windows.Forms.ColumnHeader hPrijmeni;
  private System.Windows.Forms.ColumnHeader hDatNar;
  private System.Windows.Forms.ToolStripTextBox tsHledat;
  private System.Windows.Forms.ToolStripMenuItem tsSpravaVypujcek;
 }
}