namespace Kutuphane
{
    partial class KitapBilgisiDuzenle
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtYazar = new TextBox();
            txtTur = new TextBox();
            txtYayinevi = new TextBox();
            txtKitapAdi = new TextBox();
            KitapDuzenle = new Button();
            kitapSil = new Button();
            anasayfa = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(404, 150);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 16;
            label4.Text = "Yayınevi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(404, 84);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 15;
            label3.Text = "Tür:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(53, 151);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 14;
            label2.Text = "Yazar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(53, 87);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 13;
            label1.Text = "Kitap Adı:";
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(176, 144);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(125, 27);
            txtYazar.TabIndex = 12;
            // 
            // txtTur
            // 
            txtTur.Location = new Point(548, 77);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(125, 27);
            txtTur.TabIndex = 11;
            // 
            // txtYayinevi
            // 
            txtYayinevi.Location = new Point(548, 143);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(125, 27);
            txtYayinevi.TabIndex = 10;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(176, 84);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(125, 27);
            txtKitapAdi.TabIndex = 9;
            txtKitapAdi.TextChanged += textBox1_TextChanged;
            // 
            // KitapDuzenle
            // 
            KitapDuzenle.Location = new Point(111, 285);
            KitapDuzenle.Name = "KitapDuzenle";
            KitapDuzenle.Size = new Size(100, 27);
            KitapDuzenle.TabIndex = 17;
            KitapDuzenle.Text = "Düzenle";
            KitapDuzenle.UseVisualStyleBackColor = true;
            KitapDuzenle.Click += KitapDuzenle_Click;
            // 
            // kitapSil
            // 
            kitapSil.Location = new Point(354, 285);
            kitapSil.Name = "kitapSil";
            kitapSil.Size = new Size(100, 27);
            kitapSil.TabIndex = 18;
            kitapSil.Text = "Sil";
            kitapSil.UseVisualStyleBackColor = true;
            kitapSil.Click += kitapSil_Click;
            // 
            // anasayfa
            // 
            anasayfa.Location = new Point(624, 285);
            anasayfa.Name = "anasayfa";
            anasayfa.Size = new Size(100, 27);
            anasayfa.TabIndex = 19;
            anasayfa.Text = "Anasayfa";
            anasayfa.UseVisualStyleBackColor = true;
            anasayfa.Click += anasayfa_Click;
            // 
            // KitapBilgisiDuzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(anasayfa);
            Controls.Add(kitapSil);
            Controls.Add(KitapDuzenle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtYazar);
            Controls.Add(txtTur);
            Controls.Add(txtYayinevi);
            Controls.Add(txtKitapAdi);
            Name = "KitapBilgisiDuzenle";
            Text = "KitapBilgisiDuzenle";
            Load += KitapBilgisiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtYazar;
        private TextBox txtTur;
        private TextBox txtYayinevi;
        private TextBox txtKitapAdi;
        private Button KitapDuzenle;
        private Button kitapSil;
        private Button anasayfa;
    }
}