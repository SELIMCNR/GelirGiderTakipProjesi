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
    public partial class Kar : Form
    {
        public Kar()
        {
            InitializeComponent();
        }

        private void Kar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dboGelirgiderhesabDataSet2.Kar' table. You can move, or remove it, as needed.
            this.karTableAdapter.Fill(this.dboGelirgiderhesabDataSet2.Kar);

        }

        SqlConnection bgl = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dboGelirgiderhesab.mdf;Integrated Security=True");
        private void Txt_Ekle_Click(object sender, EventArgs e)
        {
            // ekle 
            if (Txt_Giderno.Text == "" || Txt_Giderno.Text == string.Empty || Txt_Karno.Text == "" || Txt_Karno.Text == string.Empty || Txt_Gelirno.Text == "" || Txt_Gelirno.Text == string.Empty || Text_Kar.Text=="" || Text_Kar.Text==string.Empty)
            {
                MessageBox.Show("Hata alanlar boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bgl.Open();
                SqlCommand komut = new SqlCommand("insert into Kar (Karno,gelirno,giderno,kar) values (@p1,@p2,@p3,@p4)", bgl);
                komut.Parameters.AddWithValue("@p1", Txt_Karno.Text);
                komut.Parameters.AddWithValue("@p2", Txt_Gelirno.Text);
                komut.Parameters.AddWithValue("@p3", Txt_Giderno.Text);
                komut.Parameters.AddWithValue("@p4", Text_Kar.Text);
                komut.ExecuteNonQuery();
                komut.Dispose();
                bgl.Close();
                this.karTableAdapter.Fill(this.dboGelirgiderhesabDataSet2.Kar);

            }
        }

      
        

       
     
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //gride bilgileri textboxa aktarma
            Txt_Karno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Txt_Gelirno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Txt_Giderno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Text_Kar.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Text_Sil_Click_1(object sender, EventArgs e)
        {
            //sil


            bgl.Open();
            SqlCommand komut = new SqlCommand("Delete from Kar where Karno = @p1", bgl);
            komut.Parameters.AddWithValue("@p1", Txt_Karno.Text);
            komut.ExecuteNonQuery();
            komut.Dispose();
            bgl.Close();
            this.karTableAdapter.Fill(this.dboGelirgiderhesabDataSet2.Kar);
        }

        private void Text_Güncelle_Click_1(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Update Kar set gelirno=@p2,giderno=@p3 ,kar=@p4 where Karno = @p1", bgl);
            komut.Parameters.AddWithValue("@p1", Txt_Karno.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Gelirno.Text);
            komut.Parameters.AddWithValue("@p3", Txt_Giderno.Text);
            komut.Parameters.AddWithValue("@p4", Text_Kar.Text);
            komut.ExecuteNonQuery();
            komut.Dispose();
            bgl.Close();
            this.karTableAdapter.Fill(this.dboGelirgiderhesabDataSet2.Kar);
        }

        private void Text_Listele_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Kar", bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Text_Ara_Click_1(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * from Kar where Karno = @p1 ", bgl);
            komut.Parameters.AddWithValue("@p1", Txt_Karno.Text);
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            komut.Dispose();
            bgl.Close();
        }
    }
}
