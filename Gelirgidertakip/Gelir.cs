using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Gelirgidertakip
{
    public partial class Gelir : Form
    {
        public Gelir()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dboGelirgiderhesab.mdf;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dboGelirgiderhesabDataSet.Gelir' table. You can move, or remove it, as needed.
            this.gelirTableAdapter.Fill(this.dboGelirgiderhesabDataSet.Gelir);
        }

        private void Txt_Ekle_Click(object sender, EventArgs e)
        {
            //ekle
            if (Txt_Gelirno.Text == "" || Txt_Gelirno.Text == string.Empty || Txt_Gelirmiktar.Text == "" || Txt_Gelirmiktar.Text == string.Empty)
            {
                MessageBox.Show("Alanlar boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bgl.Open();
                SqlCommand komut = new SqlCommand(" insert into Gelir (gelirno,geliradı,gelirmiktarı) values (@p1,@p2,@p3)", bgl);
                komut.Parameters.AddWithValue("@p1", Txt_Gelirno.Text);
                komut.Parameters.AddWithValue("@p2", comboBox1.Text);
                komut.Parameters.AddWithValue("@p3", Txt_Gelirmiktar.Text);
                komut.ExecuteNonQuery();
                komut.Dispose();
                bgl.Close();
                this.gelirTableAdapter.Fill(this.dboGelirgiderhesabDataSet.Gelir);

            }
        }

        private void Text_Sil_Click(object sender, EventArgs e)
        {
            //sil
                
                    bgl.Open();
                    SqlCommand komut = new SqlCommand(" delete from Gelir where gelirno=@p1", bgl);
                    komut.Parameters.AddWithValue("@p1", Txt_Gelirno.Text);
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    bgl.Close();
                this.gelirTableAdapter.Fill(this.dboGelirgiderhesabDataSet.Gelir);

           
        }

        private void Text_Güncelle_Click(object sender, EventArgs e)
        {
            //güncelle
           
                if (Txt_Gelirno.Text == "" || Txt_Gelirno.Text == string.Empty || Txt_Gelirmiktar.Text == "" || Txt_Gelirmiktar.Text == string.Empty)
                {
                    MessageBox.Show("Alanlar boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bgl.Open();
                    SqlCommand komut = new SqlCommand(" update Gelir set   geliradı=@p2 ,gelirmiktarı=@p3 where gelirno=@p1", bgl);
                    komut.Parameters.AddWithValue("@p1", Txt_Gelirno.Text);
                    komut.Parameters.AddWithValue("@p2", comboBox1.Text);
                    komut.Parameters.AddWithValue("@p3", Txt_Gelirmiktar.Text);
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    bgl.Close();
                    this.gelirTableAdapter.Fill(this.dboGelirgiderhesabDataSet.Gelir);
                }

          
        }

        private void Text_Ara_Click(object sender, EventArgs e)
        {
            //ara

            bgl.Open();
            SqlCommand komut = new SqlCommand(" Select * from Gelir where gelirno= @p1 ", bgl);
            komut.Parameters.AddWithValue("@p1", Txt_Gelirno.Text);
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            komut.Dispose();
            bgl.Close();
            this.gelirTableAdapter.Fill(this.dboGelirgiderhesabDataSet.Gelir);
        }

        private void Text_Listele_Click(object sender, EventArgs e)
        {
       //listele
            SqlCommand komut = new SqlCommand("Select * from Gelir",bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            komut.Dispose();
  
        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //gride bilgileri textboxa aktarma
            Txt_Gelirno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Txt_Gelirmiktar.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
    }
    
    

