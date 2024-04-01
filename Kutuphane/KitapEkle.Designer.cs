
namespace kitap_ekle
{
    partial class KitapEkleEkran
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtKitapAdi = new TextBox();
            txtYayinevi = new TextBox();
            txtTur = new TextBox();
            txtYazar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            kitapEkle = new Button();
            kitaplistesi = new Button();
            anasayfabutton = new Button();
            SuspendLayout();
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(179, 70);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(125, 27);
            txtKitapAdi.TabIndex = 0;
            txtKitapAdi.TextChanged += txtKitapAdi_TextChanged;
            // 
            // txtYayinevi
            // 
            txtYayinevi.Location = new Point(551, 137);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(125, 27);
            txtYayinevi.TabIndex = 1;
           
            // 
            // txtTur
            // 
            txtTur.Location = new Point(551, 63);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(125, 27);
            txtTur.TabIndex = 2;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(179, 137);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(125, 27);
            txtYazar.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(56, 73);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 5;
            label1.Text = "Kitap Adı:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(56, 137);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 6;
            label2.Text = "Yazar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(407, 70);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 7;
            label3.Text = "Tür:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(407, 136);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 8;
            label4.Text = "Yayınevi:";
            label4.Click += label4_Click;
            // 
            // kitapEkle
            // 
            kitapEkle.Location = new Point(179, 263);
            kitapEkle.Name = "kitapEkle";
            kitapEkle.Size = new Size(94, 29);
            kitapEkle.TabIndex = 9;
            kitapEkle.Text = "Ekle";
            kitapEkle.UseVisualStyleBackColor = true;
            kitapEkle.Click += kitapEkle_Click;
            // 
            // kitaplistesi
            // 
            kitaplistesi.Location = new Point(382, 263);
            kitaplistesi.Name = "kitaplistesi";
            kitaplistesi.Size = new Size(99, 29);
            kitaplistesi.TabIndex = 11;
            kitaplistesi.Text = "Kitap Listesi";
            kitaplistesi.UseVisualStyleBackColor = true;
            kitaplistesi.Click += kitaplistesi_Click;
            // 
            // anasayfabutton
            // 
            anasayfabutton.Location = new Point(606, 263);
            anasayfabutton.Name = "anasayfabutton";
            anasayfabutton.Size = new Size(108, 29);
            anasayfabutton.TabIndex = 12;
            anasayfabutton.Text = "Anasayfa";
            anasayfabutton.UseVisualStyleBackColor = true;
            anasayfabutton.Click += anasayfabutton_Click;
            // 
            // KitapEkleEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(anasayfabutton);
            Controls.Add(kitaplistesi);
            Controls.Add(kitapEkle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtYazar);
            Controls.Add(txtTur);
            Controls.Add(txtYayinevi);
            Controls.Add(txtKitapAdi);
            Name = "KitapEkleEkran";
            Text = "Kitap Ekle";
            Load += KitapEkleEkran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void KitapEkleEkran_Load(object sender, EventArgs e)
        {
       
        }

        #endregion

        private TextBox txtKitapAdi;
        private TextBox txtYayinevi;
        private TextBox txtTur;
        private TextBox txtYazar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button kitapEkle;
        private Button kitaplistesi;
        private Button anasayfabutton;
    }
}
