
namespace Knihovna2021
{
 partial class Form1
 {
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  ///  Clean up any resources being used.
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
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   this.btnCtenari = new System.Windows.Forms.Button();
   this.btnKnihy = new System.Windows.Forms.Button();
   this.btnVypujcky = new System.Windows.Forms.Button();
   this.btnStatistiky = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // btnCtenari
   // 
   this.btnCtenari.Location = new System.Drawing.Point(29, 25);
   this.btnCtenari.Name = "btnCtenari";
   this.btnCtenari.Size = new System.Drawing.Size(181, 127);
   this.btnCtenari.TabIndex = 0;
   this.btnCtenari.Text = "Čtenáři";
   this.btnCtenari.UseVisualStyleBackColor = true;
   this.btnCtenari.Click += new System.EventHandler(this.btnCtenari_Click);
   // 
   // btnKnihy
   // 
   this.btnKnihy.Location = new System.Drawing.Point(216, 25);
   this.btnKnihy.Name = "btnKnihy";
   this.btnKnihy.Size = new System.Drawing.Size(181, 127);
   this.btnKnihy.TabIndex = 1;
   this.btnKnihy.Text = "Knihy";
   this.btnKnihy.UseVisualStyleBackColor = true;
   this.btnKnihy.Click += new System.EventHandler(this.btnKnihy_Click);
   // 
   // btnVypujcky
   // 
   this.btnVypujcky.Location = new System.Drawing.Point(403, 25);
   this.btnVypujcky.Name = "btnVypujcky";
   this.btnVypujcky.Size = new System.Drawing.Size(181, 127);
   this.btnVypujcky.TabIndex = 2;
   this.btnVypujcky.Text = "Výpůjčky";
   this.btnVypujcky.UseVisualStyleBackColor = true;
   this.btnVypujcky.Click += new System.EventHandler(this.btnVypujcky_Click);
   // 
   // btnStatistiky
   // 
   this.btnStatistiky.Location = new System.Drawing.Point(590, 25);
   this.btnStatistiky.Name = "btnStatistiky";
   this.btnStatistiky.Size = new System.Drawing.Size(181, 127);
   this.btnStatistiky.TabIndex = 3;
   this.btnStatistiky.Text = "Statistiky";
   this.btnStatistiky.UseVisualStyleBackColor = true;
   this.btnStatistiky.Click += new System.EventHandler(this.btnStatistiky_Click);
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(797, 177);
   this.Controls.Add(this.btnStatistiky);
   this.Controls.Add(this.btnVypujcky);
   this.Controls.Add(this.btnKnihy);
   this.Controls.Add(this.btnCtenari);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.Name = "Form1";
   this.Text = "Form1";
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnCtenari;
  private System.Windows.Forms.Button btnKnihy;
  private System.Windows.Forms.Button btnVypujcky;
  private System.Windows.Forms.Button btnStatistiky;
 }
}

