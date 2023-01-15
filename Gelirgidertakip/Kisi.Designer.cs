namespace Gelirgidertakip
{
    partial class Kisi
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
            this.components = new System.ComponentModel.Container();
            this.Text_Ara = new System.Windows.Forms.Button();
            this.Text_Listele = new System.Windows.Forms.Button();
            this.Text_Güncelle = new System.Windows.Forms.Button();
            this.Text_Sil = new System.Windows.Forms.Button();
            this.Txt_Ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_tc = new System.Windows.Forms.TextBox();
            this.Txt_Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_gelirno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_giderno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_karno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tcnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboGelirgiderhesabDataSet3 = new Gelirgidertakip.dboGelirgiderhesabDataSet3();
            this.kisiTableAdapter = new Gelirgidertakip.dboGelirgiderhesabDataSet3TableAdapters.KisiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboGelirgiderhesabDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // Text_Ara
            // 
            this.Text_Ara.Location = new System.Drawing.Point(489, 266);
            this.Text_Ara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_Ara.Name = "Text_Ara";
            this.Text_Ara.Size = new System.Drawing.Size(101, 49);
            this.Text_Ara.TabIndex = 17;
            this.Text_Ara.Text = "Ara";
            this.Text_Ara.UseVisualStyleBackColor = true;
            this.Text_Ara.Click += new System.EventHandler(this.Text_Ara_Click_1);
            // 
            // Text_Listele
            // 
            this.Text_Listele.Location = new System.Drawing.Point(380, 266);
            this.Text_Listele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_Listele.Name = "Text_Listele";
            this.Text_Listele.Size = new System.Drawing.Size(101, 49);
            this.Text_Listele.TabIndex = 16;
            this.Text_Listele.Text = "Listele";
            this.Text_Listele.UseVisualStyleBackColor = true;
            this.Text_Listele.Click += new System.EventHandler(this.Text_Listele_Click_1);
            // 
            // Text_Güncelle
            // 
            this.Text_Güncelle.Location = new System.Drawing.Point(271, 266);
            this.Text_Güncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_Güncelle.Name = "Text_Güncelle";
            this.Text_Güncelle.Size = new System.Drawing.Size(101, 49);
            this.Text_Güncelle.TabIndex = 15;
            this.Text_Güncelle.Text = "Güncelle";
            this.Text_Güncelle.UseVisualStyleBackColor = true;
            this.Text_Güncelle.Click += new System.EventHandler(this.Text_Güncelle_Click_1);
            // 
            // Text_Sil
            // 
            this.Text_Sil.Location = new System.Drawing.Point(173, 266);
            this.Text_Sil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_Sil.Name = "Text_Sil";
            this.Text_Sil.Size = new System.Drawing.Size(90, 49);
            this.Text_Sil.TabIndex = 14;
            this.Text_Sil.Text = "Sil";
            this.Text_Sil.UseVisualStyleBackColor = true;
            this.Text_Sil.Click += new System.EventHandler(this.Text_Sil_Click_1);
            // 
            // Txt_Ekle
            // 
            this.Txt_Ekle.Location = new System.Drawing.Point(75, 266);
            this.Txt_Ekle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Ekle.Name = "Txt_Ekle";
            this.Txt_Ekle.Size = new System.Drawing.Size(90, 49);
            this.Txt_Ekle.TabIndex = 13;
            this.Txt_Ekle.Text = "Ekle";
            this.Txt_Ekle.UseVisualStyleBackColor = true;
            this.Txt_Ekle.Click += new System.EventHandler(this.Txt_Ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TcNo";
            // 
            // Txt_tc
            // 
            this.Txt_tc.Location = new System.Drawing.Point(189, 19);
            this.Txt_tc.Name = "Txt_tc";
            this.Txt_tc.Size = new System.Drawing.Size(270, 26);
            this.Txt_tc.TabIndex = 2;
            // 
            // Txt_Ad
            // 
            this.Txt_Ad.Location = new System.Drawing.Point(189, 51);
            this.Txt_Ad.Name = "Txt_Ad";
            this.Txt_Ad.Size = new System.Drawing.Size(270, 26);
            this.Txt_Ad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad";
            // 
            // Txt_soyad
            // 
            this.Txt_soyad.Location = new System.Drawing.Point(189, 92);
            this.Txt_soyad.Name = "Txt_soyad";
            this.Txt_soyad.Size = new System.Drawing.Size(270, 26);
            this.Txt_soyad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad";
            // 
            // Txt_gelirno
            // 
            this.Txt_gelirno.Location = new System.Drawing.Point(189, 135);
            this.Txt_gelirno.Name = "Txt_gelirno";
            this.Txt_gelirno.Size = new System.Drawing.Size(270, 26);
            this.Txt_gelirno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gelirno";
            // 
            // Txt_giderno
            // 
            this.Txt_giderno.Location = new System.Drawing.Point(189, 179);
            this.Txt_giderno.Name = "Txt_giderno";
            this.Txt_giderno.Size = new System.Drawing.Size(270, 26);
            this.Txt_giderno.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giderno";
            // 
            // Txt_karno
            // 
            this.Txt_karno.Location = new System.Drawing.Point(189, 220);
            this.Txt_karno.Name = "Txt_karno";
            this.Txt_karno.Size = new System.Drawing.Size(270, 26);
            this.Txt_karno.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Karno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcnoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.gelirnoDataGridViewTextBoxColumn,
            this.gidernoDataGridViewTextBoxColumn,
            this.karnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kisiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(93, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 145);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // tcnoDataGridViewTextBoxColumn
            // 
            this.tcnoDataGridViewTextBoxColumn.DataPropertyName = "tcno";
            this.tcnoDataGridViewTextBoxColumn.HeaderText = "tcno";
            this.tcnoDataGridViewTextBoxColumn.Name = "tcnoDataGridViewTextBoxColumn";
            this.tcnoDataGridViewTextBoxColumn.Width = 65;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 52;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 76;
            // 
            // gelirnoDataGridViewTextBoxColumn
            // 
            this.gelirnoDataGridViewTextBoxColumn.DataPropertyName = "gelirno";
            this.gelirnoDataGridViewTextBoxColumn.HeaderText = "gelirno";
            this.gelirnoDataGridViewTextBoxColumn.Name = "gelirnoDataGridViewTextBoxColumn";
            this.gelirnoDataGridViewTextBoxColumn.Width = 81;
            // 
            // gidernoDataGridViewTextBoxColumn
            // 
            this.gidernoDataGridViewTextBoxColumn.DataPropertyName = "giderno";
            this.gidernoDataGridViewTextBoxColumn.HeaderText = "giderno";
            this.gidernoDataGridViewTextBoxColumn.Name = "gidernoDataGridViewTextBoxColumn";
            this.gidernoDataGridViewTextBoxColumn.Width = 87;
            // 
            // karnoDataGridViewTextBoxColumn
            // 
            this.karnoDataGridViewTextBoxColumn.DataPropertyName = "karno";
            this.karnoDataGridViewTextBoxColumn.HeaderText = "karno";
            this.karnoDataGridViewTextBoxColumn.Name = "karnoDataGridViewTextBoxColumn";
            this.karnoDataGridViewTextBoxColumn.Width = 74;
            // 
            // kisiBindingSource
            // 
            this.kisiBindingSource.DataMember = "Kisi";
            this.kisiBindingSource.DataSource = this.dboGelirgiderhesabDataSet3;
            // 
            // dboGelirgiderhesabDataSet3
            // 
            this.dboGelirgiderhesabDataSet3.DataSetName = "dboGelirgiderhesabDataSet3";
            this.dboGelirgiderhesabDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kisiTableAdapter
            // 
            this.kisiTableAdapter.ClearBeforeFill = true;
            // 
            // Kisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(654, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_karno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_giderno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_gelirno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_tc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_Ara);
            this.Controls.Add(this.Text_Listele);
            this.Controls.Add(this.Text_Güncelle);
            this.Controls.Add(this.Text_Sil);
            this.Controls.Add(this.Txt_Ekle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kisi";
            this.Text = "Kisi";
            this.Load += new System.EventHandler(this.Kisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboGelirgiderhesabDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Text_Ara;
        private System.Windows.Forms.Button Text_Listele;
        private System.Windows.Forms.Button Text_Güncelle;
        private System.Windows.Forms.Button Text_Sil;
        private System.Windows.Forms.Button Txt_Ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_tc;
        private System.Windows.Forms.TextBox Txt_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_gelirno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_giderno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_karno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dboGelirgiderhesabDataSet3 dboGelirgiderhesabDataSet3;
        private System.Windows.Forms.BindingSource kisiBindingSource;
        private dboGelirgiderhesabDataSet3TableAdapters.KisiTableAdapter kisiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karnoDataGridViewTextBoxColumn;
    }
}