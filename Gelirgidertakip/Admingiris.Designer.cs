namespace Gelirgidertakip
{
    partial class Admingiris
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
            this.Txt_Adsoyad = new System.Windows.Forms.TextBox();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGrs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_kod2 = new System.Windows.Forms.TextBox();
            this.Text_Kod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // Txt_Adsoyad
            // 
            this.Txt_Adsoyad.Location = new System.Drawing.Point(141, 36);
            this.Txt_Adsoyad.Name = "Txt_Adsoyad";
            this.Txt_Adsoyad.Size = new System.Drawing.Size(100, 20);
            this.Txt_Adsoyad.TabIndex = 1;
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.Location = new System.Drawing.Point(141, 71);
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.Size = new System.Drawing.Size(100, 20);
            this.Txt_Sifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // BtnGrs
            // 
            this.BtnGrs.Location = new System.Drawing.Point(141, 144);
            this.BtnGrs.Name = "BtnGrs";
            this.BtnGrs.Size = new System.Drawing.Size(75, 23);
            this.BtnGrs.TabIndex = 4;
            this.BtnGrs.Text = "GirisYap";
            this.BtnGrs.UseVisualStyleBackColor = true;
            this.BtnGrs.Click += new System.EventHandler(this.BtnGrs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(137, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Admin Login Form";
            // 
            // Text_kod2
            // 
            this.Text_kod2.Location = new System.Drawing.Point(216, 106);
            this.Text_kod2.Name = "Text_kod2";
            this.Text_kod2.Size = new System.Drawing.Size(67, 20);
            this.Text_kod2.TabIndex = 6;
            // 
            // Text_Kod
            // 
            this.Text_Kod.Location = new System.Drawing.Point(141, 106);
            this.Text_Kod.Name = "Text_Kod";
            this.Text_Kod.Size = new System.Drawing.Size(67, 20);
            this.Text_Kod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kodu gir";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(262, 154);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi unuttum";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(88, 181);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Beni Hatırla";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Admingiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 225);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Text_Kod);
            this.Controls.Add(this.Text_kod2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGrs);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Adsoyad);
            this.Controls.Add(this.label1);
            this.Name = "Admingiris";
            this.Text = "AdminGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Adsoyad;
        private System.Windows.Forms.TextBox Txt_Sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGrs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_kod2;
        private System.Windows.Forms.TextBox Text_Kod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}