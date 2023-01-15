using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gelirgidertakip
{
    public partial class Kisi : Form
    {
        public Kisi()
        {
            InitializeComponent();
        }

        private void Kisi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dboGelirgiderhesabDataSet3.Kisi' table. You can move, or remove it, as needed.
            this.kisiTableAdapter.Fill(this.dboGelirgiderhesabDataSet3.Kisi);

        }

        SqlConnection bgl = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dboGelirgiderhesab.mdf;Integrated Security=True");
        private void Txt_Ekle_Click(object sender, EventArgs e)
        {
            
 
                // ekle 
                if (Txt_giderno.Text == "" || Txt_giderno.Text == string.Empty || Txt_karno.Text == "" || Txt_karno.Text == string.Empty || Txt_gelirno.Text == "" || Txt_gelirno.Text == string.Empty || Txt_tc.Text == "" || Txt_tc.Text == string.Empty || Txt_Ad.Text =="" || Txt_Ad.Text == string.Empty || Txt_soyad.Text == "" || Txt_soyad.Text==string.Empty)
                {
                    MessageBox.Show("Hata alanlar boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bgl.Open();
                    SqlCommand komut = new SqlCommand("insert into Kisi (Karno,gelirno,giderno,tcno,ad,soyad) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl);
                    komut.Parameters.AddWithValue("@p1", Txt_karno.Text);
                    komut.Parameters.AddWithValue("@p2", Txt_gelirno.Text);
                    komut.Parameters.AddWithValue("@p3", Txt_giderno.Text);
                    komut.Parameters.AddWithValue("@p4", Txt_tc.Text);
                    komut.Parameters.AddWithValue("@p5", Txt_Ad.Text);
                    komut.Parameters.AddWithValue("@p6", Txt_soyad.Text);

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    bgl.Close();
                this.kisiTableAdapter.Fill(this.dboGelirgiderhesabDataSet3.Kisi);

            }
            }

            


        

        private void Text_Sil_Click_1(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Delete from Kisi Where tcno = @p1", bgl);
            komut.Parameters.AddWithValue("@p1", Txt_tc.Text);
            komut.ExecuteNonQuery();
            komut.Dispose();
            bgl.Close();
            this.kisiTableAdapter.Fill(this.dboGelirgiderhesabDataSet3.Kisi);
        }

        private void Text_Güncelle_Click_1(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Update Kisi set gelirno=@p2,giderno=@p3 ,karno=@p1,ad=@p5,soyad=@p6 where tcno=@p4", bgl);
            komut.Parameters.AddWithValue("@p1", Txt_karno.Text);
            komut.Parameters.AddWithValue("@p2", Txt_gelirno.Text);
            komut.Parameters.AddWithValue("@p3", Txt_giderno.Text);
            komut.Parameters.AddWithValue("@p4", Txt_tc.Text);
            komut.Parameters.AddWithValue("@p5", Txt_Ad.Text);
            komut.Parameters.AddWithValue("@p6", Txt_soyad.Text);

            komut.ExecuteNonQuery();
            komut.Dispose();
            bgl.Close();
            this.kisiTableAdapter.Fill(this.dboGelirgiderhesabDataSet3.Kisi);


        }

        private void Text_Listele_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Kisi", bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Text_Ara_Click_1(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * from Kisi where tcno = @p1 ", bgl);
            komut.Parameters.AddWithValue("@p1", Txt_tc.Text);
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            komut.Dispose();
            bgl.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //gride bilgileri textboxa aktarma
            Txt_tc.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Txt_Ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Txt_soyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Txt_gelirno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Txt_giderno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Txt_karno.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
    }

