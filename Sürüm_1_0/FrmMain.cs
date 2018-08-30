using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunGun
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frAnaSayfa = new FrmAnaSayfa();
            frAnaSayfa.LblUyeId.Text = LblUyeId.Text;
            frAnaSayfa.MdiParent = this;
            frAnaSayfa.Show();
        }

        private void BtnGunluklerim_Click(object sender, EventArgs e)
        {
            FrmGunluklerim frGunluk = new FrmGunluklerim();
            frGunluk.LblGunlukUyeId.Text = LblUyeId.Text;
            frGunluk.MdiParent = this;
            frGunluk.Show();
        }

        private void BtnYeniGunluk_Click(object sender, EventArgs e)
        {
            FrmYeniNotEkle frYeninot = new FrmYeniNotEkle();
            frYeninot.LblGunlukUyeId.Text = LblUyeId.Text;
            frYeninot.MdiParent = this;
            frYeninot.Show();
        }

        private void BtnNotlar_Click(object sender, EventArgs e)
        {
            FrmNotlar frNotlar = new FrmNotlar();
            frNotlar.LblUyeId.Text = LblUyeId.Text;
            frNotlar.MdiParent = this;
            frNotlar.Show();
        }

        private void BtnIstatistikler_Click(object sender, EventArgs e)
        {
            FrmIstatistikler frIstatistik = new FrmIstatistikler();
            frIstatistik.LblUyeId.Text = LblUyeId.Text;
            frIstatistik.MdiParent = this;
            frIstatistik.Show();
        }

        private void BtnRaporlama_Click(object sender, EventArgs e)
        {
            FrmKullanim frKullanim = new FrmKullanim();
            frKullanim.MdiParent = this;
            frKullanim.Show();
        }

        private void BtnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmAnaSayfa frAnaSayfa = new FrmAnaSayfa();
            frAnaSayfa.LblUyeId.Text = LblUyeId.Text;
            frAnaSayfa.MdiParent = this;
            frAnaSayfa.Show();
        }
    }
}
