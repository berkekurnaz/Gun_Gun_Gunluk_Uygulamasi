namespace GunGun
{
    partial class FrmAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LblTarih = new System.Windows.Forms.Label();
            this.LblSaat = new System.Windows.Forms.Label();
            this.LblGunlukSayi = new System.Windows.Forms.Label();
            this.LblNotSayi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblYazar = new System.Windows.Forms.Label();
            this.LblGununSozu = new System.Windows.Forms.Label();
            this.LblUyeId = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Son Eklediğim Günlükler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(496, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 412);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Son Eklediğim Notlar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.LblNotSayi);
            this.groupBox3.Controls.Add(this.LblGunlukSayi);
            this.groupBox3.Location = new System.Drawing.Point(12, 443);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 213);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı İstatistikler";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LblSaat);
            this.groupBox4.Controls.Add(this.LblTarih);
            this.groupBox4.Location = new System.Drawing.Point(496, 443);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tarih-Zaman";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LblGununSozu);
            this.groupBox5.Controls.Add(this.LblYazar);
            this.groupBox5.Location = new System.Drawing.Point(496, 556);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(439, 100);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Günün Sözü";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(433, 391);
            this.dataGridView2.TabIndex = 0;
            // 
            // LblTarih
            // 
            this.LblTarih.AutoSize = true;
            this.LblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTarih.Location = new System.Drawing.Point(56, 48);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(142, 20);
            this.LblTarih.TabIndex = 0;
            this.LblTarih.Text = "Tarih : 26.08.2018";
            // 
            // LblSaat
            // 
            this.LblSaat.AutoSize = true;
            this.LblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSaat.Location = new System.Drawing.Point(272, 48);
            this.LblSaat.Name = "LblSaat";
            this.LblSaat.Size = new System.Drawing.Size(99, 20);
            this.LblSaat.TabIndex = 1;
            this.LblSaat.Text = "Saat : 14:48";
            // 
            // LblGunlukSayi
            // 
            this.LblGunlukSayi.AutoSize = true;
            this.LblGunlukSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGunlukSayi.Location = new System.Drawing.Point(58, 71);
            this.LblGunlukSayi.Name = "LblGunlukSayi";
            this.LblGunlukSayi.Size = new System.Drawing.Size(288, 29);
            this.LblGunlukSayi.TabIndex = 2;
            this.LblGunlukSayi.Text = "Yazdığın Günlük Sayısı : 5";
            // 
            // LblNotSayi
            // 
            this.LblNotSayi.AutoSize = true;
            this.LblNotSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNotSayi.Location = new System.Drawing.Point(81, 134);
            this.LblNotSayi.Name = "LblNotSayi";
            this.LblNotSayi.Size = new System.Drawing.Size(251, 29);
            this.LblNotSayi.TabIndex = 3;
            this.LblNotSayi.Text = "Yazdığın Not Sayısı : 5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(58, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 4;
            // 
            // LblYazar
            // 
            this.LblYazar.AutoSize = true;
            this.LblYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYazar.Location = new System.Drawing.Point(18, 66);
            this.LblYazar.Name = "LblYazar";
            this.LblYazar.Size = new System.Drawing.Size(125, 17);
            this.LblYazar.TabIndex = 2;
            this.LblYazar.Text = "Tarih : 26.08.2018";
            // 
            // LblGununSozu
            // 
            this.LblGununSozu.AutoSize = true;
            this.LblGununSozu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGununSozu.Location = new System.Drawing.Point(18, 39);
            this.LblGununSozu.Name = "LblGununSozu";
            this.LblGununSozu.Size = new System.Drawing.Size(125, 17);
            this.LblGununSozu.TabIndex = 3;
            this.LblGununSozu.Text = "Tarih : 26.08.2018";
            // 
            // LblUyeId
            // 
            this.LblUyeId.AutoSize = true;
            this.LblUyeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUyeId.Location = new System.Drawing.Point(454, 419);
            this.LblUyeId.Name = "LblUyeId";
            this.LblUyeId.Size = new System.Drawing.Size(39, 29);
            this.LblUyeId.TabIndex = 5;
            this.LblUyeId.Text = "00";
            this.LblUyeId.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 668);
            this.Controls.Add(this.LblUyeId);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAnaSayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label LblSaat;
        private System.Windows.Forms.Label LblTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblNotSayi;
        private System.Windows.Forms.Label LblGunlukSayi;
        private System.Windows.Forms.Label LblYazar;
        private System.Windows.Forms.Label LblGununSozu;
        public System.Windows.Forms.Label LblUyeId;
        private System.Windows.Forms.Timer timer1;
    }
}