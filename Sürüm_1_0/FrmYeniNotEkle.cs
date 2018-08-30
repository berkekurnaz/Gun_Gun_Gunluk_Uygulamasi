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
    public partial class FrmYeniNotEkle : Form
    {
        public FrmYeniNotEkle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        FrmMain fr = new FrmMain();

        private void FrmYeniNotEkle_Load(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void BosAlanUyari()
        {
            MessageBox.Show("Lütfen Boş Alanları Doldurunuz...", "Uyarı Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void HataMesaj()
        {
            MessageBox.Show("Hata Oluştur...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void KayitIptalMesaj()
        {
            MessageBox.Show("Kayıt İptal Edildi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void BasariMesaj()
        {
            MessageBox.Show("Günlük Kaydı Başarıyla Eklendi", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (TxtBaslik.Text == "")
            {
                BosAlanUyari();
            }
            else
            {
                DialogResult secim = MessageBox.Show("Yeni Girilen Günlüğü Kaydetmek İstiyor Musunuz ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secim == DialogResult.Yes)
                {
                    try
                    {
                        SQLiteCommand komut = new SQLiteCommand("Insert Into TBL_GUNLUK (TARIH,RUHHALI,GUNEPUANIM,BASLIK,ICERIK,UYEID) Values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", TxtTarih.Text);
                        komut.Parameters.AddWithValue("@p2", TxtRuhHali.Text);
                        komut.Parameters.AddWithValue("@p3", Convert.ToInt32(TxtGunePuanim.Text));
                        komut.Parameters.AddWithValue("@p4", TxtBaslik.Text);
                        komut.Parameters.AddWithValue("@p5", TxtIcerik.Text);
                        komut.Parameters.AddWithValue("@p6", Convert.ToInt32(LblGunlukUyeId.Text));
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        BasariMesaj();
                    }
                    catch (Exception)
                    {
                        HataMesaj();
                    }
                }
                else
                {
                    KayitIptalMesaj();
                }
            }
        }
    }
}
