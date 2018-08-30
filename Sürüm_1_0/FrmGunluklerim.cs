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
    public partial class FrmGunluklerim : Form
    {
        public FrmGunluklerim()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmGunluklerim_Load(object sender, EventArgs e)
        {
            Verileri_Listele();
            Veri_Sayisi();

            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 0;

            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dgvBtn.HeaderText = "İşlemler";
            dgvBtn.Text = "Günlük Oku";
            dgvBtn.UseColumnTextForButtonValue = true;
            dgvBtn.DefaultCellStyle.BackColor = Color.Gray;
            dgvBtn.DefaultCellStyle.SelectionBackColor = Color.Red;
            dgvBtn.Width = 70;
            dataGridView1.Columns.Add(dgvBtn);

            Data_Grid_Stil(dataGridView1);
        }

        void Verileri_Listele()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select ID,TARIH,RUHHALI,GUNEPUANIM,BASLIK,ICERIK From TBL_GUNLUK where UYEID=@p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", LblGunlukUyeId.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int number = dataGridView1.SelectedCells[0].RowIndex;

            TxtId.Text = dataGridView1.Rows[number].Cells[1].Value.ToString();
            TxtTarih.Text = dataGridView1.Rows[number].Cells[2].Value.ToString();
            TxtRuhHali.Text = dataGridView1.Rows[number].Cells[3].Value.ToString();
            TxtGunePuanim.Text = dataGridView1.Rows[number].Cells[4].Value.ToString();
            TxtBaslik.Text = dataGridView1.Rows[number].Cells[5].Value.ToString();
            TxtIcerik.Text = dataGridView1.Rows[number].Cells[6].Value.ToString();
        }

        void Veri_Sayisi()
        {
            SQLiteCommand komut = new SQLiteCommand("Select Count(*) From TBL_GUNLUK where UYEID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblGunlukUyeId.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblGunlukSayi.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void TxtAramaTarih_TextChanged(object sender, EventArgs e)
        {
            if (TxtAramaTarih.Text == "(   )    -")
            {
                Verileri_Listele();
            }
            else
            {
                string srg = TxtAramaTarih.Text;
                string sorgu = "Select ID,TARIH,RUHHALI,GUNEPUANIM,BASLIK,ICERIK from TBL_GUNLUK where TARIH like '%" + srg + "%'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu, bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this.Hide();
                FrmGunlukDetay frDetay = new FrmGunlukDetay();
                frDetay.TxtId.Text = TxtId.Text;
                frDetay.TxtRuhHali.Text = TxtRuhHali.Text;
                frDetay.TxtGunePuanim.Text = TxtGunePuanim.Text;
                frDetay.TxtTarih.Text = TxtTarih.Text;
                frDetay.TxtBaslik.Text = TxtBaslik.Text;
                frDetay.TxtIcerik.Text = TxtIcerik.Text;
                frDetay.Show();
            }
        }

        void Data_Grid_Stil(DataGridView dt)
        {
            dt.ColumnHeadersDefaultCellStyle.BackColor = Color.Khaki;
            dt.EnableHeadersVisualStyles = false;
        }

    }
}
