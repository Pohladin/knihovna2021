
namespace Knihovna2021
{
 partial class FrmVypujcky
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
   this.lblCtenar = new System.Windows.Forms.Label();
   this.lvVypujcene = new System.Windows.Forms.ListView();
   this.hIdCtenar = new System.Windows.Forms.ColumnHeader();
   this.hNazev = new System.Windows.Forms.ColumnHeader();
   this.hAutor = new System.Windows.Forms.ColumnHeader();
   this.hPocStran = new System.Windows.Forms.ColumnHeader();
   this.hZanr = new System.Windows.Forms.ColumnHeader();
   this.lvKnihovna = new System.Windows.Forms.ListView();
   this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
   this.btnVypujcit = new System.Windows.Forms.Button();
   this.btnVratit = new System.Windows.Forms.Button();
   this.btnStorno = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // lblCtenar
   // 
   this.lblCtenar.Dock = System.Windows.Forms.DockStyle.Top;
   this.lblCtenar.Location = new System.Drawing.Point(0, 0);
   this.lblCtenar.Name = "lblCtenar";
   this.lblCtenar.Size = new System.Drawing.Size(1280, 27);
   this.lblCtenar.TabIndex = 0;
   this.lblCtenar.Text = "label1";
   // 
   // lvVypujcene
   // 
   this.lvVypujcene.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hIdCtenar,
            this.hNazev,
            this.hAutor,
            this.hPocStran,
            this.hZanr});
   this.lvVypujcene.Dock = System.Windows.Forms.DockStyle.Left;
   this.lvVypujcene.FullRowSelect = true;
   this.lvVypujcene.GridLines = true;
   this.lvVypujcene.HideSelection = false;
   this.lvVypujcene.Location = new System.Drawing.Point(0, 27);
   this.lvVypujcene.MultiSelect = false;
   this.lvVypujcene.Name = "lvVypujcene";
   this.lvVypujcene.Size = new System.Drawing.Size(536, 622);
   this.lvVypujcene.TabIndex = 4;
   this.lvVypujcene.UseCompatibleStateImageBehavior = false;
   this.lvVypujcene.View = System.Windows.Forms.View.Details;
   this.lvVypujcene.DoubleClick += new System.EventHandler(this.lvVypujcene_DoubleClick);
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
   // lvKnihovna
   // 
   this.lvKnihovna.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
   this.lvKnihovna.Dock = System.Windows.Forms.DockStyle.Right;
   this.lvKnihovna.FullRowSelect = true;
   this.lvKnihovna.GridLines = true;
   this.lvKnihovna.HideSelection = false;
   this.lvKnihovna.Location = new System.Drawing.Point(717, 27);
   this.lvKnihovna.MultiSelect = false;
   this.lvKnihovna.Name = "lvKnihovna";
   this.lvKnihovna.Size = new System.Drawing.Size(563, 622);
   this.lvKnihovna.TabIndex = 5;
   this.lvKnihovna.UseCompatibleStateImageBehavior = false;
   this.lvKnihovna.View = System.Windows.Forms.View.Details;
   this.lvKnihovna.DoubleClick += new System.EventHandler(this.lvKnihovna_DoubleClick);
   // 
   // columnHeader1
   // 
   this.columnHeader1.Text = "Id";
   // 
   // columnHeader2
   // 
   this.columnHeader2.Text = "Název";
   // 
   // columnHeader3
   // 
   this.columnHeader3.Text = "Autor";
   // 
   // columnHeader4
   // 
   this.columnHeader4.Text = "Počet stran";
   // 
   // columnHeader5
   // 
   this.columnHeader5.Text = "Žánr";
   // 
   // btnVypujcit
   // 
   this.btnVypujcit.Location = new System.Drawing.Point(552, 27);
   this.btnVypujcit.Name = "btnVypujcit";
   this.btnVypujcit.Size = new System.Drawing.Size(150, 43);
   this.btnVypujcit.TabIndex = 6;
   this.btnVypujcit.Text = "<<< Vypůjčit";
   this.btnVypujcit.UseVisualStyleBackColor = true;
   this.btnVypujcit.Click += new System.EventHandler(this.btnVypujcit_Click);
   // 
   // btnVratit
   // 
   this.btnVratit.Location = new System.Drawing.Point(552, 76);
   this.btnVratit.Name = "btnVratit";
   this.btnVratit.Size = new System.Drawing.Size(150, 43);
   this.btnVratit.TabIndex = 7;
   this.btnVratit.Text = "Vrátit >>>";
   this.btnVratit.UseVisualStyleBackColor = true;
   this.btnVratit.Click += new System.EventHandler(this.btnVratit_Click);
   // 
   // btnStorno
   // 
   this.btnStorno.Location = new System.Drawing.Point(552, 125);
   this.btnStorno.Name = "btnStorno";
   this.btnStorno.Size = new System.Drawing.Size(150, 43);
   this.btnStorno.TabIndex = 8;
   this.btnStorno.Text = "Storno";
   this.btnStorno.UseVisualStyleBackColor = true;
   this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
   // 
   // FrmVypujcky
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(1280, 649);
   this.Controls.Add(this.btnStorno);
   this.Controls.Add(this.btnVratit);
   this.Controls.Add(this.btnVypujcit);
   this.Controls.Add(this.lvKnihovna);
   this.Controls.Add(this.lvVypujcene);
   this.Controls.Add(this.lblCtenar);
   this.Name = "FrmVypujcky";
   this.Text = "Výpůjčky";
   this.Load += new System.EventHandler(this.FrmVypujcky_Load);
   this.Resize += new System.EventHandler(this.FrmVypujcky_Resize);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Label lblCtenar;
  private System.Windows.Forms.ListView lvVypujcene;
  private System.Windows.Forms.ColumnHeader hIdCtenar;
  private System.Windows.Forms.ColumnHeader hNazev;
  private System.Windows.Forms.ColumnHeader hAutor;
  private System.Windows.Forms.ColumnHeader hPocStran;
  private System.Windows.Forms.ColumnHeader hZanr;
  private System.Windows.Forms.ListView lvKnihovna;
  private System.Windows.Forms.ColumnHeader columnHeader1;
  private System.Windows.Forms.ColumnHeader columnHeader2;
  private System.Windows.Forms.ColumnHeader columnHeader3;
  private System.Windows.Forms.ColumnHeader columnHeader4;
  private System.Windows.Forms.ColumnHeader columnHeader5;
  private System.Windows.Forms.Button btnVypujcit;
  private System.Windows.Forms.Button btnVratit;
  private System.Windows.Forms.Button btnStorno;
 }
}