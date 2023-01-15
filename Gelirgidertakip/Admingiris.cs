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
    public partial class Admingiris : Form
    {
        public Admingiris()
        {
            InitializeComponent();
            kodolusturma();
        }

        public void kodolusturma()
        {
            Random rastgele = new Random();  // Random sınıfından rastgele nesnesi oluştu 
            int sayi = rastgele.Next(10000, 100000);        // rasgele'den random sayı geldi.
            Text_Kod.Text = sayi.ToString();
        }
        private void BtnGrs_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Adsoyad.Text == "" || Txt_Adsoyad.Text == string.Empty || Txt_Sifre.Text == "" || Txt_Sifre.Text == string.Empty)
                {
                    MessageBox.Show("Alanlar boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Txt_Adsoyad.Text =="Selim Çınar" && Txt_Sifre.Text == "12345" && Text_Kod.Text==Text_kod2.Text)
                {
                    AnaSayfaForum fr = new AnaSayfaForum();
                    fr.Show();
                  

                }
                else
                {
                    MessageBox.Show("Yanlış şifre veya isim girişi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
            }
            catch
            {
                ;
            }
        }
    }
}
