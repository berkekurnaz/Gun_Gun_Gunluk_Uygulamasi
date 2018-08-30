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
    public partial class FrmGunlukDetay : Form
    {
        public FrmGunlukDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Günlüğü Yeniden Güncellemek İstiyor Musunuz?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtBaslik.Text == "" || TxtTarih.Text == "" || TxtIcerik.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alanları Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SQLiteCommand komut = new SQLiteCommand("Update TBL_GUNLUK set TARIH=@p1,BASLIK=@p2,ICERIK=@p3 where ID=@P4", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtTarih.Text);
                    komut.Parameters.AddWithValue("@p2", TxtBaslik.Text);
                    komut.Parameters.AddWithValue("@p3", TxtIcerik.Text);
                    komut.Parameters.AddWithValue("@p4", TxtId.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Günlük Kaydı Başarıyla Güncellendi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            else
            {

            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Günlüğü Silmek İstiyor Musunuz?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtBaslik.Text == "" || TxtTarih.Text == "" || TxtIcerik.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alanları Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SQLiteCommand komut = new SQLiteCommand("Delete From TBL_GUNLUK Where ID=@P1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtId.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Günlük Kaydı Başarıyla Silindi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            else
            {

            }
        }

        private void FrmGunlukDetay_Load(object sender, EventArgs e)
        {

        }
    }
}
