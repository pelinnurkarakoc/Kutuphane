namespace Kutuphane
{
    partial class UyeBilgisiDuzenle
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
            txtCinsiyet = new ComboBox();
            txtSoyad = new TextBox();
            txtYas = new TextBox();
            txtAd = new TextBox();
            cinsiyetYazisi = new Label();
            yas = new Label();
            soyad = new Label();
            ad = new Label();
            UyeSil = new Button();
            label1 = new Label();
            anasayfa = new Button();
            txtKullaniciadi = new TextBox();
            kullaniciadi = new Label();
            txtUnvan = new TextBox();
            label2 = new Label();
            UyeDuzenle = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            kitabıGeriAl = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCinsiyet
            // 
            txtCinsiyet.FormattingEnabled = true;
            txtCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek", "Belirtmek İstemiyor" });
            txtCinsiyet.Location = new Point(437, 124);
            txtCinsiyet.Name = "txtCinsiyet";
            txtCinsiyet.Size = new Size(141, 28);
            txtCinsiyet.TabIndex = 30;
            txtCinsiyet.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(140, 125);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(123, 27);
            txtSoyad.TabIndex = 27;
            txtSoyad.TextChanged += txtSoyad_TextChanged;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(140, 184);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(123, 27);
            txtYas.TabIndex = 26;
            txtYas.TextChanged += txtYas_TextChanged;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(140, 69);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(123, 27);
            txtAd.TabIndex = 25;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // cinsiyetYazisi
            // 
            cinsiyetYazisi.AutoSize = true;
            cinsiyetYazisi.Location = new Point(332, 132);
            cinsiyetYazisi.Name = "cinsiyetYazisi";
            cinsiyetYazisi.Size = new Size(63, 20);
            cinsiyetYazisi.TabIndex = 22;
            cinsiyetYazisi.Text = "Cinsiyet:";
            // 
            // yas
            // 
            yas.AutoSize = true;
            yas.Location = new Point(63, 184);
            yas.Name = "yas";
            yas.Size = new Size(33, 20);
            yas.TabIndex = 21;
            yas.Text = "Yaş:";
            // 
            // soyad
            // 
            soyad.AutoSize = true;
            soyad.Location = new Point(43, 132);
            soyad.Name = "soyad";
            soyad.Size = new Size(53, 20);
            soyad.TabIndex = 20;
            soyad.Text = "Soyad:";
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.Location = new Point(63, 76);
            ad.Name = "ad";
            ad.Size = new Size(31, 20);
            ad.TabIndex = 19;
            ad.Text = "Ad:";
            // 
            // UyeSil
            // 
            UyeSil.Location = new Point(232, 357);
            UyeSil.Name = "UyeSil";
            UyeSil.Size = new Size(94, 29);
            UyeSil.TabIndex = 31;
            UyeSil.Text = "Sil";
            UyeSil.UseVisualStyleBackColor = true;
            UyeSil.Click += UyeSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(232, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 32);
            label1.TabIndex = 33;
            label1.Text = "Kullanıcı Bilgileri";
            // 
            // anasayfa
            // 
            anasayfa.BackColor = SystemColors.ControlLight;
            anasayfa.Location = new Point(645, 345);
            anasayfa.Name = "anasayfa";
            anasayfa.Size = new Size(121, 52);
            anasayfa.TabIndex = 34;
            anasayfa.Text = "Anasayfa";
            anasayfa.UseVisualStyleBackColor = false;
            anasayfa.Click += anasayfa_Click;
            // 
            // txtKullaniciadi
            // 
            txtKullaniciadi.Location = new Point(140, 254);
            txtKullaniciadi.Name = "txtKullaniciadi";
            txtKullaniciadi.Size = new Size(123, 27);
            txtKullaniciadi.TabIndex = 35;
            txtKullaniciadi.TextChanged += txtKullaniciadi_TextChanged;
            // 
            // kullaniciadi
            // 
            kullaniciadi.AutoSize = true;
            kullaniciadi.Location = new Point(-1, 254);
            kullaniciadi.Name = "kullaniciadi";
            kullaniciadi.Size = new Size(95, 20);
            kullaniciadi.TabIndex = 36;
            kullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // txtUnvan
            // 
            txtUnvan.Location = new Point(437, 62);
            txtUnvan.Name = "txtUnvan";
            txtUnvan.Size = new Size(141, 27);
            txtUnvan.TabIndex = 39;
            txtUnvan.TextChanged += txtUnvan_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 69);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 40;
            label2.Text = "Unvan:";
            // 
            // UyeDuzenle
            // 
            UyeDuzenle.Location = new Point(437, 357);
            UyeDuzenle.Name = "UyeDuzenle";
            UyeDuzenle.Size = new Size(94, 29);
            UyeDuzenle.TabIndex = 32;
            UyeDuzenle.Text = "Düzenle";
            UyeDuzenle.UseVisualStyleBackColor = true;
            UyeDuzenle.Click += UyeDuzenle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(437, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(248, 108);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 191);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 42;
            label3.Text = "Kitaplar";
            // 
            // kitabıGeriAl
            // 
            kitabıGeriAl.Location = new Point(577, 288);
            kitabıGeriAl.Name = "kitabıGeriAl";
            kitabıGeriAl.Size = new Size(108, 32);
            kitabıGeriAl.TabIndex = 43;
            kitabıGeriAl.Text = "Kitabı Geri Al";
            kitabıGeriAl.UseVisualStyleBackColor = true;
            // 
            // UyeBilgisiDuzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kitabıGeriAl);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(txtUnvan);
            Controls.Add(kullaniciadi);
            Controls.Add(txtKullaniciadi);
            Controls.Add(anasayfa);
            Controls.Add(label1);
            Controls.Add(UyeDuzenle);
            Controls.Add(UyeSil);
            Controls.Add(txtCinsiyet);
            Controls.Add(txtSoyad);
            Controls.Add(txtYas);
            Controls.Add(txtAd);
            Controls.Add(cinsiyetYazisi);
            Controls.Add(yas);
            Controls.Add(soyad);
            Controls.Add(ad);
            MaximizeBox = false;
            Name = "UyeBilgisiDuzenle";
            Text = "Kullanıcı Bilgileri";
            Load += UyeBilgisiDuzenle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txtCinsiyet;
        private TextBox txtSoyad;
        private TextBox txtYas;
        private TextBox txtAd;
        private Label cinsiyetYazisi;
        private Label yas;
        private Label soyad;
        private Label ad;
        private Button UyeSil;
        private Label label1;
        private Button anasayfa;
        private TextBox txtKullaniciadi;
        private Label kullaniciadi;
        private TextBox txtUnvan;
        private Label label2;
        private Button UyeDuzenle;
        private DataGridView dataGridView1;
        private Label label3;
        private Button kitabıGeriAl;
    }
}