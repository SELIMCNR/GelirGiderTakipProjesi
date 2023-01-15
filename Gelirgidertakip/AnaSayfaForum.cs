using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gelirgidertakip
{
    public partial class AnaSayfaForum : Form
    {
        public AnaSayfaForum()
        {

            InitializeComponent();
          
        }

       
      

        private void adminGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admingiris frmadmin = new Admingiris();
            frmadmin.ShowDialog();
            frmadmin.Dispose();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kisi frkisi = new Kisi();
            frkisi.ShowDialog();
            frkisi.Dispose();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gelir frmgelir = new Gelir();
            frmgelir.ShowDialog();
            frmgelir.Dispose();
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Gider frmgider = new Gider();
            frmgider.ShowDialog();
            frmgider.Dispose();
        }

        private void listeleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Kar frmkar = new Kar();
            frmkar.ShowDialog();
            frmkar.Dispose();

        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String mesaj = "Bu programı yazan Selim Çınardır.";
            MessageBox.Show(mesaj,"Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Tarih Saat ekleme
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
          
            //Animasyon verme
          
            sayac++;
            if (sayac % 2 == 0)
            {
                label3.BackColor = Color.Yellow;
                label3.ForeColor = Color.Blue;
                label3.BorderStyle= BorderStyle.FixedSingle  ;
            }
            else
            {
                label3.BackColor = Color.Blue;
                label3.ForeColor = Color.Yellow;
                label3.BorderStyle = BorderStyle.Fixed3D;
            }
            if (sayac == 10)
            {
                sayac = 0
;
            }

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
                 System.Diagnostics.Process.Start("WINWORD.EXE");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXCEL.EXE");
        }

        private void pointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("POWERPNT.EXE");
        }

        private void müzikToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                 System.Diagnostics.Process.Start("wmplayer.exe");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaSayfaForum_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
