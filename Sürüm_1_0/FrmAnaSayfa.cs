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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            Gunluk_Listele();
            Not_Listele();

            Gunluk_Sayi();
            Not_Sayi();

            Tarih_Yazdir(LblTarih);

            Gunun_Sozu(LblGununSozu, LblYazar);

            DataGridViewColumn column = dataGridView1.Columns[2];
            column.Width = 50;

            Data_Grid_Stil(dataGridView1);
            Data_Grid_Stil(dataGridView2);
        }

        void Gunluk_Listele()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select TARIH as 'Tarih',RUHHALI as 'Ruh Hali',GUNEPUANIM as 'Puan',BASLIK as 'Başlık' From TBL_GUNLUK Where UYEID=@p1 Order By ID Desc", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", LblUyeId.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Not_Listele()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select TARIH as 'Tarih',BASLIK as 'Başlık' From TBL_NOTLAR Where UYEID=@p1 Order By ID Desc", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", LblUyeId.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        void Gunluk_Sayi()
        {
            SQLiteCommand komut = new SQLiteCommand("Select Count(*) From TBL_GUNLUK Where UYEID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblUyeId.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblGunlukSayi.Text = "Yazdığın Günlük Sayısı : " + dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        void Not_Sayi()
        {
            SQLiteCommand komut = new SQLiteCommand("Select Count(*) From TBL_NOTLAR Where UYEID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblUyeId.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblNotSayi.Text = "Yazdığın Not Sayısı : " + dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        void Tarih_Yazdir(Label lbl)
        {
            lbl.Text = "Tarih : " + DateTime.Now.ToShortDateString();
        }

        void Gunun_Sozu(Label lblSoz,Label lblYazar)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 15);
            if (sayi == 1)
            {
                lblSoz.Text = "Güzel hayat isteyen güzel insan biriktirsin.";
                lblYazar.Text = "Cemal Süreyya";
            }
            else if(sayi == 2)
            {
                lblSoz.Text = "Önyargıları yok etmek atomu parçalamaktan zordur. ";
                lblYazar.Text = "Einstein";
            }
            else if (sayi == 3)
            {
                lblSoz.Text = "Kelebek ayları değil anları sayar ve yeterince de vakti vardır.";
                lblYazar.Text = "Tagore";
            }
            else if (sayi == 4)
            {
                lblSoz.Text = "Güzel olan sevgili değildir, sevgili olan güzeldir.";
                lblYazar.Text = "Tolstoy";
            }
            else if (sayi == 5)
            {
                lblSoz.Text = "Elin yaptığı herhangi bir şeyi bir başka el yıkabilir. ";
                lblYazar.Text = "Montaigne";
            }
            else if (sayi == 6)
            {
                lblSoz.Text = "Düşlemek bilmekten daha önemlidir.";
                lblYazar.Text = "Albert Einstein";
            }
            else if (sayi == 7)
            {
                lblSoz.Text = "Beklemesini bilenin her şey ayağına gelir.";
                lblYazar.Text = "Honore de Balzac";
            }
            else if (sayi == 8)
            {
                lblSoz.Text = "Azla mutluluk çokla didişmekten iyidir. ";
                lblYazar.Text = "Denis Diderot";
            }
            else if (sayi == 9)
            {
                lblSoz.Text = "En haksız barışı, en adil savaşa tercih ederim.";
                lblYazar.Text = "Cicero";
            }
            else if (sayi == 10)
            {
                lblSoz.Text = "Ne yaparsan yap. Yengeç yengeçtir. Doğru yürümez.";
                lblYazar.Text = "Aristophanes";
            }
            else if (sayi == 11)
            {
                lblSoz.Text = "Güzellik, çoğu zaman kusurları gizleyen bir örtüdür.";
                lblYazar.Text = "Honore de Balzac";
            }
            else if (sayi == 12)
            {
                lblSoz.Text = "Yazı yazmayı öğrenmek, her şeyden önce düşünmeyi öğrenmektir.";
                lblYazar.Text = "Amie Suche";
            }
            else if (sayi == 13)
            {
                lblSoz.Text = "Hiç kimse yumrukları sıkılıyken net düşünemez.";
                lblYazar.Text = "George Jean Nuthar";
            }
            else if (sayi == 14)
            {
                lblSoz.Text = "Yalnız yaptıklarımızdan değil, yapmadıklarımızdan da sorumluyuz.";
                lblYazar.Text = "Moliere";
            }
            else if (sayi == 15)
            {
                lblSoz.Text = "Herkes başka birinin beceremediği bir konuda ustadır.";
                lblYazar.Text = "Publis Syrevs";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblSaat.Text = "Saat : " + DateTime.Now.ToShortTimeString();
        }

        void Data_Grid_Stil(DataGridView dt)
        {
            dt.ColumnHeadersDefaultCellStyle.BackColor = Color.Khaki;
            dt.EnableHeadersVisualStyles = false;
        }
    }
}
