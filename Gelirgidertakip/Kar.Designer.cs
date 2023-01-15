namespace Gelirgidertakip
{
    partial class Kar
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
            this.Txt_Karno = new System.Windows.Forms.TextBox();
            this.Txt_Gelirno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Giderno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_Kar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.karnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboGelirgiderhesabDataSet2 = new Gelirgidertakip.dboGelirgiderhesabDataSet2();
            this.karTableAdapter = new Gelirgidertakip.dboGelirgiderhesabDataSet2TableAdapters.KarTableAdapter();
            this.Text_Ara = new System.Windows.Forms.Button();
            this.Text_Listele = new System.Windows.Forms.Button();
            this.Text_Güncelle = new System.Windows.Forms.Button();
            this.Text_Sil = new System.Windows.Forms.Button();
            this.Txt_Ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboGelirgiderhesabDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karno";
            // 
            // Txt_Karno
            // 
            this.Txt_Karno.Location = new System.Drawing.Point(135, 38);
            this.Txt_Karno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Karno.Name = "Txt_Karno";
            this.Txt_Karno.Size = new System.Drawing.Size(260, 26);
            this.Txt_Karno.TabIndex = 1;
            // 
            // Txt_Gelirno
            // 
            this.Txt_Gelirno.Location = new System.Drawing.Point(135, 99);
            this.Txt_Gelirno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Gelirno.Name = "Txt_Gelirno";
            this.Txt_Gelirno.Size = new System.Drawing.Size(260, 26);
            this.Txt_Gelirno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gelirno";
            // 
            // Txt_Giderno
            // 
            this.Txt_Giderno.Location = new System.Drawing.Point(135, 165);
            this.Txt_Giderno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Giderno.Name = "Txt_Giderno";
            this.Txt_Giderno.Size = new System.Drawing.Size(260, 26);
            this.Txt_Giderno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giderno";
            // 
            // Text_Kar
            // 
            this.Text_Kar.Location = new System.Drawing.Point(135, 227);
            this.Text_Kar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_Kar.Name = "Text_Kar";
            this.Text_Kar.Size = new System.Drawing.Size(260, 26);
            this.Text_Kar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.karnoDataGridViewTextBoxColumn,
            this.gelirnoDataGridViewTextBoxColumn,
            this.gidernoDataGridViewTextBoxColumn,
            this.karDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.karBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // karnoDataGridViewTextBoxColumn
            // 
            this.karnoDataGridViewTextBoxColumn.DataPropertyName = "Karno";
            this.karnoDataGridViewTextBoxColumn.HeaderText = "Karno";
            this.karnoDataGridViewTextBoxColumn.Name = "karnoDataGridViewTextBoxColumn";
            // 
            // gelirnoDataGridViewTextBoxColumn
            // 
            this.gelirnoDataGridViewTextBoxColumn.DataPropertyName = "gelirno";
            this.gelirnoDataGridViewTextBoxColumn.HeaderText = "gelirno";
            this.gelirnoDataGridViewTextBoxColumn.Name = "gelirnoDataGridViewTextBoxColumn";
            // 
            // gidernoDataGridViewTextBoxColumn
            // 
            this.gidernoDataGridViewTextBoxColumn.DataPropertyName = "giderno";
            this.gidernoDataGridViewTextBoxColumn.HeaderText = "giderno";
            this.gidernoDataGridViewTextBoxColumn.Name = "gidernoDataGridViewTextBoxColumn";
            // 
            // karDataGridViewTextBoxColumn
            // 
            this.karDataGridViewTextBoxColumn.DataPropertyName = "kar";
            this.karDataGridViewTextBoxColumn.HeaderText = "kar";
            this.karDataGridViewTextBoxColumn.Name = "karDataGridViewTextBoxColumn";
            // 
            // karBindingSource
            // 
            this.karBindingSource.DataMember = "Kar";
            this.karBindingSource.DataSource = this.dboGelirgiderhesabDataSet2;
            // 
            // dboGelirgiderhesabDataSet2
            // 
            this.dboGelirgiderhesabDataSet2.DataSetName = "dboGelirgiderhesabDataSet2";
            this.dboGelirgiderhesabDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karTableAdapter
            // 
            this.karTableAdapter.ClearBeforeFill = true;
            // 
            // Text_Ara
            // 
            this.Text_Ara.Location = new System.Drawing.Point(363, 269);
            this.Text_Ara.Name = "Text_Ara";
            this.Text_Ara.Size = new System.Drawing.Size(82, 32);
            this.Text_Ara.TabIndex = 22;
            this.Text_Ara.Text = "Ara";
            this.Text_Ara.UseVisualStyleBackColor = true;
            this.Text_Ara.Click += new System.EventHandler(this.Text_Ara_Click_1);
            // 
            // Text_Listele
            // 
            this.Text_Listele.Location = new System.Drawing.Point(275, 269);
            this.Text_Listele.Name = "Text_Listele";
            this.Text_Listele.Size = new System.Drawing.Size(82, 32);
            this.Text_Listele.TabIndex = 21;
            this.Text_Listele.Text = "Listele";
            this.Text_Listele.UseVisualStyleBackColor = true;
            this.Text_Listele.Click += new System.EventHandler(this.Text_Listele_Click_1);
            // 
            // Text_Güncelle
            // 
            this.Text_Güncelle.Location = new System.Drawing.Point(183, 269);
            this.Text_Güncelle.Name = "Text_Güncelle";
            this.Text_Güncelle.Size = new System.Drawing.Size(82, 32);
            this.Text_Güncelle.TabIndex = 20;
            this.Text_Güncelle.Text = "Güncelle";
            this.Text_Güncelle.UseVisualStyleBackColor = true;
            this.Text_Güncelle.Click += new System.EventHandler(this.Text_Güncelle_Click_1);
            // 
            // Text_Sil
            // 
            this.Text_Sil.Location = new System.Drawing.Point(102, 269);
            this.Text_Sil.Name = "Text_Sil";
            this.Text_Sil.Size = new System.Drawing.Size(75, 32);
            this.Text_Sil.TabIndex = 19;
            this.Text_Sil.Text = "Sil";
            this.Text_Sil.UseVisualStyleBackColor = true;
            this.Text_Sil.Click += new System.EventHandler(this.Text_Sil_Click_1);
            // 
            // Txt_Ekle
            // 
            this.Txt_Ekle.Location = new System.Drawing.Point(21, 269);
            this.Txt_Ekle.Name = "Txt_Ekle";
            this.Txt_Ekle.Size = new System.Drawing.Size(75, 32);
            this.Txt_Ekle.TabIndex = 18;
            this.Txt_Ekle.Text = "Ekle";
            this.Txt_Ekle.UseVisualStyleBackColor = true;
            this.Txt_Ekle.Click += new System.EventHandler(this.Txt_Ekle_Click);
            // 
            // Kar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(459, 485);
            this.Controls.Add(this.Text_Ara);
            this.Controls.Add(this.Text_Listele);
            this.Controls.Add(this.Text_Güncelle);
            this.Controls.Add(this.Text_Sil);
            this.Controls.Add(this.Txt_Ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Text_Kar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Giderno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Gelirno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Karno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kar";
            this.Text = "Kar";
            this.Load += new System.EventHandler(this.Kar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboGelirgiderhesabDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Karno;
        private System.Windows.Forms.TextBox Txt_Gelirno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Giderno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_Kar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dboGelirgiderhesabDataSet2 dboGelirgiderhesabDataSet2;
        private System.Windows.Forms.BindingSource karBindingSource;
        private dboGelirgiderhesabDataSet2TableAdapters.KarTableAdapter karTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn karnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button Text_Ara;
        private System.Windows.Forms.Button Text_Listele;
        private System.Windows.Forms.Button Text_Güncelle;
        private System.Windows.Forms.Button Text_Sil;
        private System.Windows.Forms.Button Txt_Ekle;
    }
}