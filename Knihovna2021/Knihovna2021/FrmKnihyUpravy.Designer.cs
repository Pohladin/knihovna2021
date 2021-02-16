
namespace Knihovna2021
{
 partial class FrmKnihyUpravy
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
   this.btnStorno = new System.Windows.Forms.Button();
   this.btnUlozit = new System.Windows.Forms.Button();
   this.label3 = new System.Windows.Forms.Label();
   this.txtAutor = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.txtNazev = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.txtZanr = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.numPocetStran = new System.Windows.Forms.NumericUpDown();
   ((System.ComponentModel.ISupportInitialize)(this.numPocetStran)).BeginInit();
   this.SuspendLayout();
   // 
   // btnStorno
   // 
   this.btnStorno.Location = new System.Drawing.Point(230, 118);
   this.btnStorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
   this.btnStorno.Name = "btnStorno";
   this.btnStorno.Size = new System.Drawing.Size(82, 22);
   this.btnStorno.TabIndex = 15;
   this.btnStorno.Text = "Storno";
   this.btnStorno.UseVisualStyleBackColor = true;
   this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
   // 
   // btnUlozit
   // 
   this.btnUlozit.Location = new System.Drawing.Point(142, 118);
   this.btnUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
   this.btnUlozit.Name = "btnUlozit";
   this.btnUlozit.Size = new System.Drawing.Size(82, 22);
   this.btnUlozit.TabIndex = 14;
   this.btnUlozit.Text = "Uložit";
   this.btnUlozit.UseVisualStyleBackColor = true;
   this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(14, 65);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(69, 15);
   this.label3.TabIndex = 12;
   this.label3.Text = "Počet stran:";
   // 
   // txtAutor
   // 
   this.txtAutor.Location = new System.Drawing.Point(123, 36);
   this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
   this.txtAutor.Name = "txtAutor";
   this.txtAutor.Size = new System.Drawing.Size(189, 23);
   this.txtAutor.TabIndex = 11;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(14, 40);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(37, 15);
   this.label2.TabIndex = 10;
   this.label2.Text = "Autor";
   // 
   // txtNazev
   // 
   this.txtNazev.Location = new System.Drawing.Point(123, 11);
   this.txtNazev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
   this.txtNazev.Name = "txtNazev";
   this.txtNazev.Size = new System.Drawing.Size(189, 23);
   this.txtNazev.TabIndex = 9;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(14, 15);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(42, 15);
   this.label1.TabIndex = 8;
   this.label1.Text = "Název:";
   // 
   // txtZanr
   // 
   this.txtZanr.Location = new System.Drawing.Point(123, 91);
   this.txtZanr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
   this.txtZanr.Name = "txtZanr";
   this.txtZanr.Size = new System.Drawing.Size(189, 23);
   this.txtZanr.TabIndex = 17;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(14, 95);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(37, 15);
   this.label4.TabIndex = 16;
   this.label4.Text = "Autor";
   // 
   // numPocetStran
   // 
   this.numPocetStran.Location = new System.Drawing.Point(123, 63);
   this.numPocetStran.Name = "numPocetStran";
   this.numPocetStran.Size = new System.Drawing.Size(189, 23);
   this.numPocetStran.TabIndex = 18;
   // 
   // FrmKnihyUpravy
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(327, 158);
   this.Controls.Add(this.numPocetStran);
   this.Controls.Add(this.txtZanr);
   this.Controls.Add(this.label4);
   this.Controls.Add(this.btnStorno);
   this.Controls.Add(this.btnUlozit);
   this.Controls.Add(this.label3);
   this.Controls.Add(this.txtAutor);
   this.Controls.Add(this.label2);
   this.Controls.Add(this.txtNazev);
   this.Controls.Add(this.label1);
   this.Name = "FrmKnihyUpravy";
   this.Text = "Kniha";
   this.Load += new System.EventHandler(this.FrmKnihyUpravy_Load);
   ((System.ComponentModel.ISupportInitialize)(this.numPocetStran)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Button btnStorno;
  private System.Windows.Forms.Button btnUlozit;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtAutor;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtNazev;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtZanr;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.NumericUpDown numPocetStran;
 }
}