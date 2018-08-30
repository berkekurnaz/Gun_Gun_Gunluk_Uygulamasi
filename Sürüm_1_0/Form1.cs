using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GunGun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public bool giris(string kullanici,string sifre)
        {
            SQLiteCommand komut = new SQLiteCommand("Select * From TBL_UYE Where KULLANICIADI=@p1 And SIFRE=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1" , kullanici);
            komut.Parameters.AddWithValue("@p2", sifre);
            SQLiteDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                bgl.baglanti().Close();
                return true;
            }
            else
            {
                bgl.baglanti().Close();
                return false;
            }
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            bool girisislemi = giris(TxtKullaniciAdi.Text, TxtSifre.Text);
            if (girisislemi == true)
            {
                /* KULLANICI ADINA GORE UYENIN ID'SINI BULMA */
                SQLiteCommand komut = new SQLiteCommand("Select ID From TBL_UYE Where KULLANICIADI=@P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtKullaniciAdi.Text);
                SQLiteDataReader dr = komut.ExecuteReader();
                while(dr.Read())
                {
                    LblId.Text = dr[0].ToString();
                }

                FrmMain fr = new FrmMain();
                fr.LblMainAdSoyad.Text = "Hoşgeldin : " + TxtKullaniciAdi.Text;
                fr.LblUyeId.Text = LblId.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı...", "Uyarı Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LblYeniKullanici_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmYeniKullanici fr = new FrmYeniKullanici();
            fr.Show();
            this.Hide();
        }
    }
}
