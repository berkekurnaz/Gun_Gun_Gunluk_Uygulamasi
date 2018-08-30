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
    public partial class FrmIstatistikler : Form
    {
        public FrmIstatistikler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmIstatistikler_Load(object sender, EventArgs e)
        {

            Gunluk_Sayisi();
            Olumlu_Sayi();
            Notr_Sayi();
            Olumsuz_Sayi();
            Puan_Sayi(LblPuan0,0);
            Puan_Sayi(LblPuan1, 1);
            Puan_Sayi(LblPuan2, 2);
            Puan_Sayi(LblPuan3, 3);
            Puan_Sayi(LblPuan4, 4);
            Puan_Sayi(LblPuan5, 5);
            Puan_Sayi(LblPuan6, 6);
            Puan_Sayi(LblPuan7, 7);
            Puan_Sayi(LblPuan8, 8);
            Puan_Sayi(LblPuan9, 9);
            Puan_Sayi(LblPuan10, 10);
            Puan_Ortalama();

            Not_Sayisi();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTarih.Text = "Sistem Tarihi : " + DateTime.Now.ToString();
        }

        /* GUNLUKLERLE ILGILI ISTATISTIKLER */
        void Gunluk_Sayisi()
        {
            SQLiteCommand komut = new SQLiteCommand("Select Count(*) From TBL_GUNLUK Where UYEID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblUyeId.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblGunlukSayi.Text = "Yazmış Olduğun Günlük Sayısı : " + dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        void Olumlu_Sayi()
        {
            SQLiteCommand komut = new SQLiteCommand("Select Count(*) From TBL_GUNLUK Where RUHHALI='Olumlu' And UYEID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblUyeId.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblOlumluSaayi.Text = "Ruh Hali 'Olumlu' Günlük Sayısı : " + dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        void Notr_Sayi()
        {
            SQLiteCommand komut = new SQLiteCommand("Select Count(*) From TBL_GUNLUK Where RUHHALI='Nötr' And UYEID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblUyeId.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblNotrSayi.Text = "Ruh Hali 'Nötr' Günlük Sayısı : " + dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        void Olumsuz_Sayi()
        {
            SQLiteCommand komut = new SQLiteCommand("Select Count(*) From TBL_GUNLUK Where RUHHALI='Olumsuz' And UYEID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblUyeId.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblOlumsuzSayi.Text = "Ruh Hali 'Olumsuz' Günlük Sayısı : " + dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        void Puan_Sayi(Label lbl,int i)
        {
            SQLiteCommand komut = new SQLiteCommand("Select Count(*) From TBL_GUNLUK Where GUNEPUANIM=@p2 And UYEID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblUyeId.Text);
            komut.Parameters.AddWithValue("@p2", i);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl.Text = "Güne Puanım ' " + i +"' Olan Günlük Sayısı : " + dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        void Puan_Ortalama()
        {
            SQLiteCommand komut = new SQLiteCommand("Select Avg(GUNEPUANIM) From TBL_GUNLUK Where UYEID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblUyeId.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblPuanOrtalama.Text = "Günlere Verdiğin Puan Ortalaması : " + dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        /* NOTLARLA ILGILI ISTATISTIKLER */
        void Not_Sayisi()
        {
            SQLiteCommand komut = new SQLiteCommand("Select Count(*) From TBL_NOTLAR Where UYEID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblUyeId.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblNotSayisi.Text = "Yazmış Olduğun Not Sayısı : " + dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

    }
}
