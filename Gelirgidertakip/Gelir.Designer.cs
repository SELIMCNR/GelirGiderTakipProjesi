namespace Gelirgidertakip
{
    partial class Gelir
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gelirnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geliradıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirmiktarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboGelirgiderhesabDataSet = new Gelirgidertakip.dboGelirgiderhesabDataSet();
            this.gelirTableAdapter = new Gelirgidertakip.dboGelirgiderhesabDataSetTableAdapters.GelirTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Gelirno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Gelirmiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Txt_Ekle = new System.Windows.Forms.Button();
            this.Text_Sil = new System.Windows.Forms.Button();
            this.Text_Güncelle = new System.Windows.Forms.Button();
            this.Text_Listele = new System.Windows.Forms.Button();
            this.Text_Ara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboGelirgiderhesabDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gelirnoDataGridViewTextBoxColumn,
            this.geliradıDataGridViewTextBoxColumn,
            this.gelirmiktarıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gelirBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 269);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 145);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gelirnoDataGridViewTextBoxColumn
            // 
            this.gelirnoDataGridViewTextBoxColumn.DataPropertyName = "gelirno";
            this.gelirnoDataGridViewTextBoxColumn.HeaderText = "gelirno";
            this.gelirnoDataGridViewTextBoxColumn.Name = "gelirnoDataGridViewTextBoxColumn";
            // 
            // geliradıDataGridViewTextBoxColumn
            // 
            this.geliradıDataGridViewTextBoxColumn.DataPropertyName = "geliradı";
            this.geliradıDataGridViewTextBoxColumn.HeaderText = "geliradı";
            this.geliradıDataGridViewTextBoxColumn.Name = "geliradıDataGridViewTextBoxColumn";
            // 
            // gelirmiktarıDataGridViewTextBoxColumn
            // 
            this.gelirmiktarıDataGridViewTextBoxColumn.DataPropertyName = "gelirmiktarı";
            this.gelirmiktarıDataGridViewTextBoxColumn.HeaderText = "gelirmiktarı";
            this.gelirmiktarıDataGridViewTextBoxColumn.Name = "gelirmiktarıDataGridViewTextBoxColumn";
            // 
            // gelirBindingSource
            // 
            this.gelirBindingSource.DataMember = "Gelir";
            this.gelirBindingSource.DataSource = this.dboGelirgiderhesabDataSet;
            // 
            // dboGelirgiderhesabDataSet
            // 
            this.dboGelirgiderhesabDataSet.DataSetName = "dboGelirgiderhesabDataSet";
            this.dboGelirgiderhesabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gelirTableAdapter
            // 
            this.gelirTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gelirno";
            // 
            // Txt_Gelirno
            // 
            this.Txt_Gelirno.Location = new System.Drawing.Point(152, 29);
            this.Txt_Gelirno.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Gelirno.Name = "Txt_Gelirno";
            this.Txt_Gelirno.Size = new System.Drawing.Size(210, 26);
            this.Txt_Gelirno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gelir adı ";
            // 
            // Txt_Gelirmiktar
            // 
            this.Txt_Gelirmiktar.Location = new System.Drawing.Point(152, 146);
            this.Txt_Gelirmiktar.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Gelirmiktar.Name = "Txt_Gelirmiktar";
            this.Txt_Gelirmiktar.Size = new System.Drawing.Size(210, 26);
            this.Txt_Gelirmiktar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gelir miktarı";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Maaş ",
            "Pasif gelir"});
            this.comboBox1.Location = new System.Drawing.Point(152, 95);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 26);
            this.comboBox1.TabIndex = 4;
            // 
            // Txt_Ekle
            // 
            this.Txt_Ekle.Location = new System.Drawing.Point(14, 212);
            this.Txt_Ekle.Name = "Txt_Ekle";
            this.Txt_Ekle.Size = new System.Drawing.Size(75, 32);
            this.Txt_Ekle.TabIndex = 8;
            this.Txt_Ekle.Text = "Ekle";
            this.Txt_Ekle.UseVisualStyleBackColor = true;
            this.Txt_Ekle.Click += new System.EventHandler(this.Txt_Ekle_Click);
            // 
            // Text_Sil
            // 
            this.Text_Sil.Location = new System.Drawing.Point(95, 212);
            this.Text_Sil.Name = "Text_Sil";
            this.Text_Sil.Size = new System.Drawing.Size(75, 32);
            this.Text_Sil.TabIndex = 9;
            this.Text_Sil.Text = "Sil";
            this.Text_Sil.UseVisualStyleBackColor = true;
            this.Text_Sil.Click += new System.EventHandler(this.Text_Sil_Click);
            // 
            // Text_Güncelle
            // 
            this.Text_Güncelle.Location = new System.Drawing.Point(176, 212);
            this.Text_Güncelle.Name = "Text_Güncelle";
            this.Text_Güncelle.Size = new System.Drawing.Size(82, 32);
            this.Text_Güncelle.TabIndex = 10;
            this.Text_Güncelle.Text = "Güncelle";
            this.Text_Güncelle.UseVisualStyleBackColor = true;
            this.Text_Güncelle.Click += new System.EventHandler(this.Text_Güncelle_Click);
            // 
            // Text_Listele
            // 
            this.Text_Listele.Location = new System.Drawing.Point(268, 212);
            this.Text_Listele.Name = "Text_Listele";
            this.Text_Listele.Size = new System.Drawing.Size(82, 32);
            this.Text_Listele.TabIndex = 11;
            this.Text_Listele.Text = "Listele";
            this.Text_Listele.UseVisualStyleBackColor = true;
            this.Text_Listele.Click += new System.EventHandler(this.Text_Listele_Click);
            // 
            // Text_Ara
            // 
            this.Text_Ara.Location = new System.Drawing.Point(356, 212);
            this.Text_Ara.Name = "Text_Ara";
            this.Text_Ara.Size = new System.Drawing.Size(82, 32);
            this.Text_Ara.TabIndex = 12;
            this.Text_Ara.Text = "Ara";
            this.Text_Ara.UseVisualStyleBackColor = true;
            this.Text_Ara.Click += new System.EventHandler(this.Text_Ara_Click);
            // 
            // Gelir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 427);
            this.Controls.Add(this.Text_Ara);
            this.Controls.Add(this.Text_Listele);
            this.Controls.Add(this.Text_Güncelle);
            this.Controls.Add(this.Text_Sil);
            this.Controls.Add(this.Txt_Ekle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Txt_Gelirmiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Gelirno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gelir";
            this.Text = "Gelir";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboGelirgiderhesabDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dboGelirgiderhesabDataSet dboGelirgiderhesabDataSet;
        private System.Windows.Forms.BindingSource gelirBindingSource;
        private dboGelirgiderhesabDataSetTableAdapters.GelirTableAdapter gelirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geliradıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirmiktarıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Gelirno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Gelirmiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Txt_Ekle;
        private System.Windows.Forms.Button Text_Sil;
        private System.Windows.Forms.Button Text_Güncelle;
        private System.Windows.Forms.Button Text_Listele;
        private System.Windows.Forms.Button Text_Ara;
    }
}

