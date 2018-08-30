namespace GunGun
{
    partial class FrmYeniNotEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblGunlukUyeId = new System.Windows.Forms.Label();
            this.TxtGunePuanim = new System.Windows.Forms.ComboBox();
            this.TxtRuhHali = new System.Windows.Forms.ComboBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtIcerik = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBaslik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTarih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblGunlukUyeId);
            this.groupBox1.Controls.Add(this.TxtGunePuanim);
            this.groupBox1.Controls.Add(this.TxtRuhHali);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.TxtIcerik);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtBaslik);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtTarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 644);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LblGunlukUyeId
            // 
            this.LblGunlukUyeId.AutoSize = true;
            this.LblGunlukUyeId.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGunlukUyeId.Location = new System.Drawing.Point(15, 18);
            this.LblGunlukUyeId.Name = "LblGunlukUyeId";
            this.LblGunlukUyeId.Size = new System.Drawing.Size(25, 29);
            this.LblGunlukUyeId.TabIndex = 15;
            this.LblGunlukUyeId.Text = "0";
            this.LblGunlukUyeId.Visible = false;
            // 
            // TxtGunePuanim
            // 
            this.TxtGunePuanim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtGunePuanim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGunePuanim.FormattingEnabled = true;
            this.TxtGunePuanim.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.TxtGunePuanim.Location = new System.Drawing.Point(505, 199);
            this.TxtGunePuanim.Name = "TxtGunePuanim";
            this.TxtGunePuanim.Size = new System.Drawing.Size(222, 32);
            this.TxtGunePuanim.TabIndex = 14;
            // 
            // TxtRuhHali
            // 
            this.TxtRuhHali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtRuhHali.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRuhHali.FormattingEnabled = true;
            this.TxtRuhHali.Items.AddRange(new object[] {
            "Olumlu",
            "Nötr",
            "Olumsuz"});
            this.TxtRuhHali.Location = new System.Drawing.Point(177, 199);
            this.TxtRuhHali.Name = "TxtRuhHali";
            this.TxtRuhHali.Size = new System.Drawing.Size(222, 32);
            this.TxtRuhHali.TabIndex = 13;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.LightGreen;
            this.BtnEkle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEkle.Location = new System.Drawing.Point(359, 570);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(213, 55);
            this.BtnEkle.TabIndex = 12;
            this.BtnEkle.Text = "Yeni Günlük Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtIcerik
            // 
            this.TxtIcerik.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtIcerik.Location = new System.Drawing.Point(123, 364);
            this.TxtIcerik.Name = "TxtIcerik";
            this.TxtIcerik.Size = new System.Drawing.Size(700, 187);
            this.TxtIcerik.TabIndex = 11;
            this.TxtIcerik.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(427, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "İçerik";
            // 
            // TxtBaslik
            // 
            this.TxtBaslik.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBaslik.Location = new System.Drawing.Point(321, 279);
            this.TxtBaslik.Name = "TxtBaslik";
            this.TxtBaslik.Size = new System.Drawing.Size(289, 32);
            this.TxtBaslik.TabIndex = 9;
            this.TxtBaslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(425, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Başlık";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(543, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Güne Puanım";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(244, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ruh Hali";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Location = new System.Drawing.Point(350, 114);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(222, 32);
            this.TxtTarih.TabIndex = 3;
            this.TxtTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(429, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(260, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Günlük Ekleme Ekranı";
            // 
            // FrmYeniNotEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 668);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmYeniNotEkle";
            this.Text = "Yeni Günlük Ekle";
            this.Load += new System.EventHandler(this.FrmYeniNotEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTarih;
        private System.Windows.Forms.TextBox TxtBaslik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox TxtIcerik;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.ComboBox TxtGunePuanim;
        private System.Windows.Forms.ComboBox TxtRuhHali;
        public System.Windows.Forms.Label LblGunlukUyeId;
    }
}