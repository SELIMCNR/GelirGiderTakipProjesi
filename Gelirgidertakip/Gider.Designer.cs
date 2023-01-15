namespace Gelirgidertakip
{
    partial class Gider
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Giderno = new System.Windows.Forms.TextBox();
            this.Txt_Gideradı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_GiderMiktarı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gidernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gideradıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidermiktarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboGelirgiderhesabDataSet1 = new Gelirgidertakip.dboGelirgiderhesabDataSet1();
            this.giderTableAdapter = new Gelirgidertakip.dboGelirgiderhesabDataSet1TableAdapters.GiderTableAdapter();
            this.Text_Ara = new System.Windows.Forms.Button();
            this.Text_Listele = new System.Windows.Forms.Button();
            this.Text_Güncelle = new System.Windows.Forms.Button();
            this.Text_Sil = new System.Windows.Forms.Button();
            this.Txt_Ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboGelirgiderhesabDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giderno";
            // 
            // Txt_Giderno
            // 
            this.Txt_Giderno.Location = new System.Drawing.Point(117, 39);
            this.Txt_Giderno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Giderno.Name = "Txt_Giderno";
            this.Txt_Giderno.Size = new System.Drawing.Size(224, 26);
            this.Txt_Giderno.TabIndex = 1;
            // 
            // Txt_Gideradı
            // 
            this.Txt_Gideradı.Location = new System.Drawing.Point(117, 103);
            this.Txt_Gideradı.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Gideradı.Name = "Txt_Gideradı";
            this.Txt_Gideradı.Size = new System.Drawing.Size(224, 26);
            this.Txt_Gideradı.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gider Adı";
            // 
            // Txt_GiderMiktarı
            // 
            this.Txt_GiderMiktarı.Location = new System.Drawing.Point(117, 168);
            this.Txt_GiderMiktarı.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_GiderMiktarı.Name = "Txt_GiderMiktarı";
            this.Txt_GiderMiktarı.Size = new System.Drawing.Size(224, 26);
            this.Txt_GiderMiktarı.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gider Miktarı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gidernoDataGridViewTextBoxColumn,
            this.gideradıDataGridViewTextBoxColumn,
            this.gidermiktarıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gidernoDataGridViewTextBoxColumn
            // 
            this.gidernoDataGridViewTextBoxColumn.DataPropertyName = "giderno";
            this.gidernoDataGridViewTextBoxColumn.HeaderText = "giderno";
            this.gidernoDataGridViewTextBoxColumn.Name = "gidernoDataGridViewTextBoxColumn";
            // 
            // gideradıDataGridViewTextBoxColumn
            // 
            this.gideradıDataGridViewTextBoxColumn.DataPropertyName = "gideradı";
            this.gideradıDataGridViewTextBoxColumn.HeaderText = "gideradı";
            this.gideradıDataGridViewTextBoxColumn.Name = "gideradıDataGridViewTextBoxColumn";
            // 
            // gidermiktarıDataGridViewTextBoxColumn
            // 
            this.gidermiktarıDataGridViewTextBoxColumn.DataPropertyName = "gidermiktarı";
            this.gidermiktarıDataGridViewTextBoxColumn.HeaderText = "gidermiktarı";
            this.gidermiktarıDataGridViewTextBoxColumn.Name = "gidermiktarıDataGridViewTextBoxColumn";
            // 
            // giderBindingSource
            // 
            this.giderBindingSource.DataMember = "Gider";
            this.giderBindingSource.DataSource = this.dboGelirgiderhesabDataSet1;
            this.giderBindingSource.CurrentChanged += new System.EventHandler(this.giderBindingSource_CurrentChanged);
            // 
            // dboGelirgiderhesabDataSet1
            // 
            this.dboGelirgiderhesabDataSet1.DataSetName = "dboGelirgiderhesabDataSet1";
            this.dboGelirgiderhesabDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderTableAdapter
            // 
            this.giderTableAdapter.ClearBeforeFill = true;
            // 
            // Text_Ara
            // 
            this.Text_Ara.Location = new System.Drawing.Point(361, 222);
            this.Text_Ara.Name = "Text_Ara";
            this.Text_Ara.Size = new System.Drawing.Size(82, 32);
            this.Text_Ara.TabIndex = 17;
            this.Text_Ara.Text = "Ara";
            this.Text_Ara.UseVisualStyleBackColor = true;
            this.Text_Ara.Click += new System.EventHandler(this.Text_Ara_Click);
            // 
            // Text_Listele
            // 
            this.Text_Listele.Location = new System.Drawing.Point(273, 222);
            this.Text_Listele.Name = "Text_Listele";
            this.Text_Listele.Size = new System.Drawing.Size(82, 32);
            this.Text_Listele.TabIndex = 16;
            this.Text_Listele.Text = "Listele";
            this.Text_Listele.UseVisualStyleBackColor = true;
            this.Text_Listele.Click += new System.EventHandler(this.Text_Listele_Click);
            // 
            // Text_Güncelle
            // 
            this.Text_Güncelle.Location = new System.Drawing.Point(181, 222);
            this.Text_Güncelle.Name = "Text_Güncelle";
            this.Text_Güncelle.Size = new System.Drawing.Size(82, 32);
            this.Text_Güncelle.TabIndex = 15;
            this.Text_Güncelle.Text = "Güncelle";
            this.Text_Güncelle.UseVisualStyleBackColor = true;
            this.Text_Güncelle.Click += new System.EventHandler(this.Text_Güncelle_Click);
            // 
            // Text_Sil
            // 
            this.Text_Sil.Location = new System.Drawing.Point(100, 222);
            this.Text_Sil.Name = "Text_Sil";
            this.Text_Sil.Size = new System.Drawing.Size(75, 32);
            this.Text_Sil.TabIndex = 14;
            this.Text_Sil.Text = "Sil";
            this.Text_Sil.UseVisualStyleBackColor = true;
            this.Text_Sil.Click += new System.EventHandler(this.Text_Sil_Click);
            // 
            // Txt_Ekle
            // 
            this.Txt_Ekle.Location = new System.Drawing.Point(19, 222);
            this.Txt_Ekle.Name = "Txt_Ekle";
            this.Txt_Ekle.Size = new System.Drawing.Size(75, 32);
            this.Txt_Ekle.TabIndex = 13;
            this.Txt_Ekle.Text = "Ekle";
            this.Txt_Ekle.UseVisualStyleBackColor = true;
            this.Txt_Ekle.Click += new System.EventHandler(this.Txt_Ekle_Click);
            // 
            // Gider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(458, 455);
            this.Controls.Add(this.Text_Ara);
            this.Controls.Add(this.Text_Listele);
            this.Controls.Add(this.Text_Güncelle);
            this.Controls.Add(this.Text_Sil);
            this.Controls.Add(this.Txt_Ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_GiderMiktarı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Gideradı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Giderno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Gider";
            this.Load += new System.EventHandler(this.Gider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboGelirgiderhesabDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Giderno;
        private System.Windows.Forms.TextBox Txt_Gideradı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_GiderMiktarı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dboGelirgiderhesabDataSet1 dboGelirgiderhesabDataSet1;
        private System.Windows.Forms.BindingSource giderBindingSource;
        private dboGelirgiderhesabDataSet1TableAdapters.GiderTableAdapter giderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gideradıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidermiktarıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Text_Listele;
        private System.Windows.Forms.Button Text_Güncelle;
        private System.Windows.Forms.Button Text_Sil;
        private System.Windows.Forms.Button Txt_Ekle;
        public System.Windows.Forms.Button Text_Ara;
    }
}