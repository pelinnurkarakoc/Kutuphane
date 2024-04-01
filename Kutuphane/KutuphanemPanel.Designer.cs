namespace Kutuphane
{
    partial class KutuphanemPanel
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
            kitapEkle = new Button();
            teslimIslemleri = new Button();
            kitapListele2 = new Button();
            kitapListele = new Button();
            label2 = new Label();
            uyeListesi = new Button();
            uyeEkle = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            teslimAldığımKitaplar = new Button();
            label3 = new Label();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // kitapEkle
            // 
            kitapEkle.Location = new Point(3, 114);
            kitapEkle.Name = "kitapEkle";
            kitapEkle.Size = new Size(179, 106);
            kitapEkle.TabIndex = 0;
            kitapEkle.Text = "Kitap Ekle";
            kitapEkle.UseVisualStyleBackColor = true;
            kitapEkle.Click += kitapEkle_Click;
            // 
            // teslimIslemleri
            // 
            teslimIslemleri.Location = new Point(23, 261);
            teslimIslemleri.Name = "teslimIslemleri";
            teslimIslemleri.Size = new Size(177, 115);
            teslimIslemleri.TabIndex = 0;
            teslimIslemleri.Text = "Teslim İşlemleri";
            teslimIslemleri.UseVisualStyleBackColor = true;
            teslimIslemleri.UseWaitCursor = true;
            teslimIslemleri.Click += teslimIslemleri_Click;
            // 
            // kitapListele2
            // 
            kitapListele2.Location = new Point(184, 3);
            kitapListele2.Name = "kitapListele2";
            kitapListele2.Size = new Size(176, 100);
            kitapListele2.TabIndex = 2;
            kitapListele2.Text = "Kitap Listesi";
            kitapListele2.UseVisualStyleBackColor = true;
            kitapListele2.Click += kitapListele2_Click;
            // 
            // kitapListele
            // 
            kitapListele.Location = new Point(188, 114);
            kitapListele.Name = "kitapListele";
            kitapListele.Size = new Size(179, 106);
            kitapListele.TabIndex = 3;
            kitapListele.Text = "Kitapları Listele";
            kitapListele.UseVisualStyleBackColor = true;
            kitapListele.Click += kitapListele_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(18, 10);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 8;
            label2.Text = "Admin Paneli";
            label2.Click += label2_Click;
            // 
            // uyeListesi
            // 
            uyeListesi.Location = new Point(188, 3);
            uyeListesi.Name = "uyeListesi";
            uyeListesi.Size = new Size(179, 105);
            uyeListesi.TabIndex = 0;
            uyeListesi.Text = "Üye Listesi";
            uyeListesi.UseVisualStyleBackColor = true;
            uyeListesi.UseWaitCursor = true;
            uyeListesi.Click += uyeListesi_Click;
            // 
            // uyeEkle
            // 
            uyeEkle.Location = new Point(3, 3);
            uyeEkle.Name = "uyeEkle";
            uyeEkle.Size = new Size(179, 105);
            uyeEkle.TabIndex = 2;
            uyeEkle.Text = "Üye Ekle";
            uyeEkle.UseVisualStyleBackColor = true;
            uyeEkle.Click += uyeEkle_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(kitapListele, 1, 1);
            tableLayoutPanel2.Controls.Add(kitapEkle, 0, 1);
            tableLayoutPanel2.Controls.Add(uyeEkle, 0, 0);
            tableLayoutPanel2.Controls.Add(uyeListesi, 1, 0);
            tableLayoutPanel2.Location = new Point(18, 35);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(370, 223);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(kitapListele2, 1, 0);
            tableLayoutPanel3.Controls.Add(teslimAldığımKitaplar, 0, 0);
            tableLayoutPanel3.Location = new Point(508, 35);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(363, 212);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // teslimAldığımKitaplar
            // 
            teslimAldığımKitaplar.Location = new Point(3, 3);
            teslimAldığımKitaplar.Name = "teslimAldığımKitaplar";
            teslimAldığımKitaplar.Size = new Size(172, 100);
            teslimAldığımKitaplar.TabIndex = 0;
            teslimAldığımKitaplar.Text = "Teslim aldığım\r\n kitaplar";
            teslimAldığımKitaplar.UseVisualStyleBackColor = true;
            teslimAldığımKitaplar.Click += teslimAldığımKitaplar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(508, 9);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 11;
            label3.Text = " Üye Panel";
            // 
            // KutuphanemPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1058, 534);
            Controls.Add(teslimIslemleri);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label2);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "KutuphanemPanel";
            Text = "Kütüphanem Panel";
            Load += Form2_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button verButonu;
        private Button alButonu;
        private Button kitapListele2;
        private Button kitapListele;
        private Label label2;
        private Button button1;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button7;
        private Button button6;
        private Button teslimAldığımKitaplar;
        private Label label3;
        private Button teslimIslemleri;
        private Button kitapEkle;
        private Button uyeEkle;
        private Button uyeListesi;
    }
}