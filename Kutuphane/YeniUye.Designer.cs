
namespace Button_formları
{
    partial class YeniUye
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        //tekrar başlatmak

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ad = new Label();
            soyad = new Label();
            yas = new Label();
            cinsiyet = new Label();
            txtAd = new TextBox();
            label7 = new Label();
            txtYas = new TextBox();
            txtSoyad = new TextBox();
            ekle = new Button();
            uyeListesi = new Button();
            anasayfa = new Button();
            txtCinsiyet = new ComboBox();
            txtKullaniciAdi = new TextBox();
            label1 = new Label();
            txtUnvan = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.Location = new Point(34, 89);
            ad.Name = "ad";
            ad.Size = new Size(28, 20);
            ad.TabIndex = 1;
            ad.Text = "Ad";
            // 
            // soyad
            // 
            soyad.AutoSize = true;
            soyad.Location = new Point(12, 144);
            soyad.Name = "soyad";
            soyad.Size = new Size(50, 20);
            soyad.TabIndex = 2;
            soyad.Text = "Soyad";
            // 
            // yas
            // 
            yas.AutoSize = true;
            yas.Location = new Point(32, 203);
            yas.Name = "yas";
            yas.Size = new Size(30, 20);
            yas.TabIndex = 3;
            yas.Text = "Yaş";
            // 
            // cinsiyet
            // 
            cinsiyet.AutoSize = true;
            cinsiyet.Location = new Point(350, 89);
            cinsiyet.Name = "cinsiyet";
            cinsiyet.Size = new Size(60, 20);
            cinsiyet.TabIndex = 4;
            cinsiyet.Text = "Cinsiyet";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(111, 82);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(176, 27);
            txtAd.TabIndex = 7;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(264, 9);
            label7.Name = "label7";
            label7.Size = new Size(194, 38);
            label7.TabIndex = 8;
            label7.Text = "YENİ ÜYE ";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(110, 203);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(176, 27);
            txtYas.TabIndex = 10;
            txtYas.TextChanged += txtYas_TextChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(111, 144);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(176, 27);
            txtSoyad.TabIndex = 11;
            // 
            // ekle
            // 
            ekle.BackColor = SystemColors.ControlLight;
            ekle.Location = new Point(52, 341);
            ekle.Name = "ekle";
            ekle.Size = new Size(106, 39);
            ekle.TabIndex = 14;
            ekle.Text = "Ekle";
            ekle.UseVisualStyleBackColor = false;
            ekle.Click += ekle_Click;
            // 
            // uyeListesi
            // 
            uyeListesi.BackColor = SystemColors.ControlLight;
            uyeListesi.Location = new Point(286, 341);
            uyeListesi.Name = "uyeListesi";
            uyeListesi.Size = new Size(106, 39);
            uyeListesi.TabIndex = 15;
            uyeListesi.Text = "Üye Listesi";
            uyeListesi.UseVisualStyleBackColor = false;
            uyeListesi.Click += uyeListesi_Click;
            // 
            // anasayfa
            // 
            anasayfa.BackColor = SystemColors.ControlLight;
            anasayfa.Location = new Point(556, 341);
            anasayfa.Name = "anasayfa";
            anasayfa.Size = new Size(106, 39);
            anasayfa.TabIndex = 16;
            anasayfa.Text = "Anasayfa";
            anasayfa.UseVisualStyleBackColor = false;
            anasayfa.Click += anasayfa_Click_1;
            // 
            // txtCinsiyet
            // 
            txtCinsiyet.FormattingEnabled = true;
            txtCinsiyet.Items.AddRange(new object[] { "Kız", "Erkek", "Belirtmek İstemiyor" });
            txtCinsiyet.Location = new Point(457, 82);
            txtCinsiyet.Name = "txtCinsiyet";
            txtCinsiyet.Size = new Size(176, 28);
            txtCinsiyet.TabIndex = 18;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(457, 150);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(176, 27);
            txtKullaniciAdi.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 150);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 20;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtUnvan
            // 
            txtUnvan.Location = new Point(457, 207);
            txtUnvan.Name = "txtUnvan";
            txtUnvan.Size = new Size(176, 27);
            txtUnvan.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 210);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 22;
            label2.Text = "Ünvan";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(457, 263);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(176, 27);
            txtSifre.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 266);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 24;
            label3.Text = "Sifre";
            // 
            // YeniUye
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 462);
            Controls.Add(label3);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txtUnvan);
            Controls.Add(label1);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtCinsiyet);
            Controls.Add(anasayfa);
            Controls.Add(uyeListesi);
            Controls.Add(ekle);
            Controls.Add(txtSoyad);
            Controls.Add(txtYas);
            Controls.Add(label7);
            Controls.Add(txtAd);
            Controls.Add(cinsiyet);
            Controls.Add(yas);
            Controls.Add(soyad);
            Controls.Add(ad);
            MaximizeBox = false;
            Name = "YeniUye";
            Text = "Kütüphane";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion
        private Label ad;
        private Label soyad;
        private Label yas;
        private Label cinsiyet;
        private TextBox txtAd;
        private Label label7;
        private TextBox txtYas;
        private TextBox txtSoyad;
        private Button ekle;
        private Button uyeListesi;
        private Button cikis;
        private ComboBox txtCinsiyet;
        private Button anasayfa;
        private TextBox txtKullanici_adi;
        private Label label1;
        private TextBox txtUnvan;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
    }
}
