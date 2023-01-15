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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Gelirgidertakip
{
    public partial class Gider : Form
    {
        public Gider()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dboGelirgiderhesab.mdf;Integrated Security=True");
        private void Gider_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dboGelirgiderhesabDataSet1.Gider' table. You can move, or remove it, as needed.
            this.giderTableAdapter.Fill(this.dboGelirgiderhesabDataSet1.Gider);

        }

        private void dboGelirgiderhesabDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void giderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Ekle_Click(object sender, EventArgs e)
        {
            // ekle 
            if (Txt_Giderno.Text == "" || Txt_Giderno.Text == string.Empty || Txt_Gideradı.Text == "" || Txt_Gideradı.Text == string.Empty || Txt_GiderMiktarı.Text == "" || Txt_GiderMiktarı.Text == string.Empty)
            {
                MessageBox.Show("Hata alanlar boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bgl.Open();
                SqlCommand komut = new SqlCommand("insert into Gider (giderno,gideradı,gidermiktarı) values (@p1,@p2,@p3)", bgl);
                komut.Parameters.AddWithValue("@p1", Txt_Giderno.Text);
                komut.Parameters.AddWithValue("@p2", Txt_Gideradı.Text);
                komut.Parameters.AddWithValue("@p3", Txt_GiderMiktarı.Text);
                komut.ExecuteNonQuery();
                komut.Dispose();
                bgl.Close();

                this.giderTableAdapter.Fill(this.dboGelirgiderhesabDataSet1.Gider);
            }
        }

        private void Text_Sil_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Delete from Gider Where giderno = @p1",bgl);
            komut.Parameters.AddWithValue("@p1",Txt_Giderno.Text);
            komut.ExecuteNonQuery();
            komut.Dispose();
            bgl.Close();
            this.giderTableAdapter.Fill(this.dboGelirgiderhesabDataSet1.Gider);
        }

        private void Text_Güncelle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Update Gider set gideradı=@p2,gidermiktarı=@p3 where giderno = @p1", bgl);
            komut.Parameters.AddWithValue("@p1",Txt_Giderno.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Gideradı.Text);
            komut.Parameters.AddWithValue("@p3", Txt_GiderMiktarı.Text);
            komut.ExecuteNonQuery();
            komut.Dispose();
            bgl.Close();
            this.giderTableAdapter.Fill(this.dboGelirgiderhesabDataSet1.Gider);
        }

        private void Text_Listele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Gider",bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
         
        }

        private void Text_Ara_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * from Gider where giderno = @p1 ", bgl);
            komut.Parameters.AddWithValue("@p1", Txt_Giderno.Text);
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            komut.Dispose();
            bgl.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //gride bilgileri textboxa aktarma
            Txt_Giderno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Txt_Gideradı.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Txt_GiderMiktarı.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
