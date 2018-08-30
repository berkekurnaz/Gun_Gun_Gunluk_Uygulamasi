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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            Listele();
            ToplamNotSayisi();

            TxtTarih.Text = DateTime.Now.ToShortDateString();

            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 0;

            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dgvBtn.HeaderText = "İşlemler";
            dgvBtn.Text = "Not Oku";
            dgvBtn.UseColumnTextForButtonValue = true;
            dgvBtn.DefaultCellStyle.BackColor = Color.Gray;
            dgvBtn.DefaultCellStyle.SelectionBackColor = Color.Red;
            dgvBtn.Width = 70;
            dataGridView1.Columns.Add(dgvBtn);

            Data_Grid_Stil(dataGridView1);
        }

        void Listele()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select ID,TARIH,BASLIK,ICERIK From TBL_NOTLAR Where UYEID=@p1 Order By ID Desc", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", LblUyeId.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void ToplamNotSayisi()
        {
            SQLiteCommand komut = new SQLiteCommand("Select Count(*) From TBL_NOTLAR Where UYEID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblUyeId.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblToplamNot.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        void HataMesaj()
        {
            MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnYeniNotEkle_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Not Eklemek İstiyor Musunuz ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                try
                {
                    SQLiteCommand komut = new SQLiteCommand("insert into TBL_NOTLAR (TARIH,BASLIK,ICERIK,UYEID) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtTarih.Text);
                    komut.Parameters.AddWithValue("@p2", TxtBaslik.Text);
                    komut.Parameters.AddWithValue("@p3", TxtIcerik.Text);
                    komut.Parameters.AddWithValue("@p4", LblUyeId.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Not Başarıyla Eklendi", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    ToplamNotSayisi();
                }
                catch (Exception)
                {
                    HataMesaj();
                }
            }
            else
            {
                Listele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Not Güncellemek İstiyor Musunuz ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                try
                {
                    SQLiteCommand komut = new SQLiteCommand("Update TBL_NOTLAR set TARIH=@P1,BASLIK=@P2,ICERIK=@P3 where ID=@P4", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtTarih.Text);
                    komut.Parameters.AddWithValue("@p2", TxtBaslik.Text);
                    komut.Parameters.AddWithValue("@p3", TxtIcerik.Text);
                    komut.Parameters.AddWithValue("@p4", TxtId.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Not Başarıyla Güncellendi", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
                catch (Exception)
                {
                    HataMesaj();
                }
            }
            else
            {
                Listele();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Not Silmek İstiyor Musunuz ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                try
                {
                    SQLiteCommand komut = new SQLiteCommand("Delete From TBL_NOTLAR where ID=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtId.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Not Başarıyla Silindi", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    ToplamNotSayisi();
                }
                catch (Exception)
                {
                    HataMesaj();
                }
            }
            else
            {
                Listele();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int number = dataGridView1.SelectedCells[0].RowIndex;

                TxtId.Text = dataGridView1.Rows[number].Cells[1].Value.ToString();
                TxtTarih.Text = dataGridView1.Rows[number].Cells[2].Value.ToString();
                TxtBaslik.Text = dataGridView1.Rows[number].Cells[3].Value.ToString();
                TxtIcerik.Text = dataGridView1.Rows[number].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                FrmNotDetay fr = new FrmNotDetay();
                fr.TxtTarih.Text = TxtTarih.Text;
                fr.TxtBaslik.Text = TxtBaslik.Text;
                fr.TxtIcerik.Text = TxtIcerik.Text;
                fr.Show();
            }
        }

        void Data_Grid_Stil(DataGridView dt)
        {
            dt.ColumnHeadersDefaultCellStyle.BackColor = Color.Khaki;
            dt.EnableHeadersVisualStyles = false;
        }
    }
}
