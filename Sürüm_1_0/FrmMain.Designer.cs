namespace GunGun
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblUyeId = new System.Windows.Forms.Label();
            this.LblMainAdSoyad = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCikisYap = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRaporlama = new DevExpress.XtraEditors.SimpleButton();
            this.BtnIstatistikler = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNotlar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnYeniGunluk = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGunluklerim = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAnaSayfa = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblUyeId);
            this.panel1.Controls.Add(this.LblMainAdSoyad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 44);
            this.panel1.TabIndex = 0;
            // 
            // LblUyeId
            // 
            this.LblUyeId.AutoSize = true;
            this.LblUyeId.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUyeId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUyeId.Location = new System.Drawing.Point(518, 9);
            this.LblUyeId.Name = "LblUyeId";
            this.LblUyeId.Size = new System.Drawing.Size(0, 24);
            this.LblUyeId.TabIndex = 1;
            this.LblUyeId.Visible = false;
            // 
            // LblMainAdSoyad
            // 
            this.LblMainAdSoyad.AutoSize = true;
            this.LblMainAdSoyad.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMainAdSoyad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblMainAdSoyad.Location = new System.Drawing.Point(15, 9);
            this.LblMainAdSoyad.Name = "LblMainAdSoyad";
            this.LblMainAdSoyad.Size = new System.Drawing.Size(222, 24);
            this.LblMainAdSoyad.TabIndex = 0;
            this.LblMainAdSoyad.Text = "Hoşgeldin : Berke Kurnaz";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnCikisYap);
            this.panel2.Controls.Add(this.BtnRaporlama);
            this.panel2.Controls.Add(this.BtnIstatistikler);
            this.panel2.Controls.Add(this.BtnNotlar);
            this.panel2.Controls.Add(this.BtnYeniGunluk);
            this.panel2.Controls.Add(this.BtnGunluklerim);
            this.panel2.Controls.Add(this.BtnAnaSayfa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 705);
            this.panel2.TabIndex = 1;
            // 
            // BtnCikisYap
            // 
            this.BtnCikisYap.Appearance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikisYap.Appearance.Options.UseFont = true;
            this.BtnCikisYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCikisYap.ImageOptions.Image")));
            this.BtnCikisYap.Location = new System.Drawing.Point(11, 620);
            this.BtnCikisYap.Name = "BtnCikisYap";
            this.BtnCikisYap.Size = new System.Drawing.Size(244, 71);
            this.BtnCikisYap.TabIndex = 6;
            this.BtnCikisYap.Text = "Çıkış Yap";
            this.BtnCikisYap.Click += new System.EventHandler(this.BtnCikisYap_Click);
            // 
            // BtnRaporlama
            // 
            this.BtnRaporlama.Appearance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRaporlama.Appearance.Options.UseFont = true;
            this.BtnRaporlama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRaporlama.ImageOptions.Image")));
            this.BtnRaporlama.Location = new System.Drawing.Point(14, 520);
            this.BtnRaporlama.Name = "BtnRaporlama";
            this.BtnRaporlama.Size = new System.Drawing.Size(244, 71);
            this.BtnRaporlama.TabIndex = 5;
            this.BtnRaporlama.Text = "Kullanım";
            this.BtnRaporlama.Click += new System.EventHandler(this.BtnRaporlama_Click);
            // 
            // BtnIstatistikler
            // 
            this.BtnIstatistikler.Appearance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIstatistikler.Appearance.Options.UseFont = true;
            this.BtnIstatistikler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnIstatistikler.ImageOptions.Image")));
            this.BtnIstatistikler.Location = new System.Drawing.Point(14, 420);
            this.BtnIstatistikler.Name = "BtnIstatistikler";
            this.BtnIstatistikler.Size = new System.Drawing.Size(244, 71);
            this.BtnIstatistikler.TabIndex = 4;
            this.BtnIstatistikler.Text = "İstatistikler";
            this.BtnIstatistikler.Click += new System.EventHandler(this.BtnIstatistikler_Click);
            // 
            // BtnNotlar
            // 
            this.BtnNotlar.Appearance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNotlar.Appearance.Options.UseFont = true;
            this.BtnNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotlar.ImageOptions.Image")));
            this.BtnNotlar.Location = new System.Drawing.Point(14, 320);
            this.BtnNotlar.Name = "BtnNotlar";
            this.BtnNotlar.Size = new System.Drawing.Size(244, 71);
            this.BtnNotlar.TabIndex = 3;
            this.BtnNotlar.Text = "Notlar";
            this.BtnNotlar.Click += new System.EventHandler(this.BtnNotlar_Click);
            // 
            // BtnYeniGunluk
            // 
            this.BtnYeniGunluk.Appearance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniGunluk.Appearance.Options.UseFont = true;
            this.BtnYeniGunluk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnYeniGunluk.ImageOptions.Image")));
            this.BtnYeniGunluk.Location = new System.Drawing.Point(11, 220);
            this.BtnYeniGunluk.Name = "BtnYeniGunluk";
            this.BtnYeniGunluk.Size = new System.Drawing.Size(244, 71);
            this.BtnYeniGunluk.TabIndex = 2;
            this.BtnYeniGunluk.Text = "Yeni Günlük";
            this.BtnYeniGunluk.Click += new System.EventHandler(this.BtnYeniGunluk_Click);
            // 
            // BtnGunluklerim
            // 
            this.BtnGunluklerim.Appearance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGunluklerim.Appearance.Options.UseFont = true;
            this.BtnGunluklerim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGunluklerim.ImageOptions.Image")));
            this.BtnGunluklerim.Location = new System.Drawing.Point(11, 120);
            this.BtnGunluklerim.Name = "BtnGunluklerim";
            this.BtnGunluklerim.Size = new System.Drawing.Size(244, 71);
            this.BtnGunluklerim.TabIndex = 1;
            this.BtnGunluklerim.Text = "Günlüklerim";
            this.BtnGunluklerim.Click += new System.EventHandler(this.BtnGunluklerim_Click);
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.Appearance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAnaSayfa.Appearance.Options.UseFont = true;
            this.BtnAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnaSayfa.ImageOptions.Image")));
            this.BtnAnaSayfa.Location = new System.Drawing.Point(11, 20);
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.Size = new System.Drawing.Size(244, 71);
            this.BtnAnaSayfa.TabIndex = 0;
            this.BtnAnaSayfa.Text = "Anasayfa";
            this.BtnAnaSayfa.Click += new System.EventHandler(this.BtnAnaSayfa_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1260, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gün Gün Günlük";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton BtnAnaSayfa;
        private DevExpress.XtraEditors.SimpleButton BtnGunluklerim;
        private DevExpress.XtraEditors.SimpleButton BtnNotlar;
        private DevExpress.XtraEditors.SimpleButton BtnYeniGunluk;
        private DevExpress.XtraEditors.SimpleButton BtnIstatistikler;
        private DevExpress.XtraEditors.SimpleButton BtnRaporlama;
        private DevExpress.XtraEditors.SimpleButton BtnCikisYap;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public System.Windows.Forms.Label LblMainAdSoyad;
        public System.Windows.Forms.Label LblUyeId;
    }
}