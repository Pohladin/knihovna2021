
namespace Knihovna2021
{
 partial class FrmCtenariUpravy
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
   this.label1 = new System.Windows.Forms.Label();
   this.txtJmeno = new System.Windows.Forms.TextBox();
   this.txtPrijmeni = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.dtpDatNar = new System.Windows.Forms.DateTimePicker();
   this.btnUlozit = new System.Windows.Forms.Button();
   this.btnStorno = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 27);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(55, 20);
   this.label1.TabIndex = 0;
   this.label1.Text = "Jméno:";
   // 
   // txtJmeno
   // 
   this.txtJmeno.Location = new System.Drawing.Point(136, 22);
   this.txtJmeno.Name = "txtJmeno";
   this.txtJmeno.Size = new System.Drawing.Size(215, 27);
   this.txtJmeno.TabIndex = 1;
   // 
   // txtPrijmeni
   // 
   this.txtPrijmeni.Location = new System.Drawing.Point(136, 55);
   this.txtPrijmeni.Name = "txtPrijmeni";
   this.txtPrijmeni.Size = new System.Drawing.Size(215, 27);
   this.txtPrijmeni.TabIndex = 3;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(12, 60);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(63, 20);
   this.label2.TabIndex = 2;
   this.label2.Text = "Příjmení";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(12, 93);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(118, 20);
   this.label3.TabIndex = 4;
   this.label3.Text = "Datum narození:";
   // 
   // dtpDatNar
   // 
   this.dtpDatNar.CustomFormat = "dd.MM.yyyy";
   this.dtpDatNar.Location = new System.Drawing.Point(136, 88);
   this.dtpDatNar.Name = "dtpDatNar";
   this.dtpDatNar.Size = new System.Drawing.Size(215, 27);
   this.dtpDatNar.TabIndex = 5;
   // 
   // btnUlozit
   // 
   this.btnUlozit.Location = new System.Drawing.Point(157, 131);
   this.btnUlozit.Name = "btnUlozit";
   this.btnUlozit.Size = new System.Drawing.Size(94, 29);
   this.btnUlozit.TabIndex = 6;
   this.btnUlozit.Text = "Uložit";
   this.btnUlozit.UseVisualStyleBackColor = true;
   this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
   // 
   // btnStorno
   // 
   this.btnStorno.Location = new System.Drawing.Point(257, 131);
   this.btnStorno.Name = "btnStorno";
   this.btnStorno.Size = new System.Drawing.Size(94, 29);
   this.btnStorno.TabIndex = 7;
   this.btnStorno.Text = "Storno";
   this.btnStorno.UseVisualStyleBackColor = true;
   this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
   // 
   // FrmCtenariUpravy
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(368, 177);
   this.Controls.Add(this.btnStorno);
   this.Controls.Add(this.btnUlozit);
   this.Controls.Add(this.dtpDatNar);
   this.Controls.Add(this.label3);
   this.Controls.Add(this.txtPrijmeni);
   this.Controls.Add(this.label2);
   this.Controls.Add(this.txtJmeno);
   this.Controls.Add(this.label1);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.Name = "FrmCtenariUpravy";
   this.Text = "Čtenář";
   this.Load += new System.EventHandler(this.FrmCtenariUpravy_Load);
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtJmeno;
  private System.Windows.Forms.TextBox txtPrijmeni;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpDatNar;
  private System.Windows.Forms.Button btnUlozit;
  private System.Windows.Forms.Button btnStorno;
 }
}