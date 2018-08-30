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
    public partial class FrmYeniKullanici : Form
    {
        public FrmYeniKullanici()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmYeniKullanici_Load(object sender, EventArgs e)
        {

        }



        private void TxtKullaniciOlustur_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text == "" || TxtAdSoyad.Text == "" || TxtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz...", "Uyarı Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult secim = MessageBox.Show("Yeni Kullanıcı Oluşturmak İstiyor Musunuz?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim == DialogResult.Yes)
                {
                    SQLiteCommand komut = new SQLiteCommand("insert into TBL_UYE (ADSOYAD,KULLANICIADI,SIFRE) Values (@p1,@p2,@p3)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@p2", TxtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@p3", TxtSifre.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kullanıcı Başarıyla Oluşturuldu", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 fr = new Form1();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Oluşturma İptal Edildi...", "Bilgi  Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LblGirisEkrani_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
