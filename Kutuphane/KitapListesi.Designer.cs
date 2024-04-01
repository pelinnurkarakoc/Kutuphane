namespace Kutuphane
{
    partial class KitapListesi
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
            kitapSil = new Button();
            kitapEkle = new Button();
            anasayfa = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // kitapSil
            // 
            kitapSil.Location = new Point(152, 387);
            kitapSil.Name = "kitapSil";
            kitapSil.Size = new Size(94, 29);
            kitapSil.TabIndex = 2;
            kitapSil.Text = "Sil";
            kitapSil.UseVisualStyleBackColor = true;
            kitapSil.Click += kitapSil_Click;
            // 
            // kitapEkle
            // 
            kitapEkle.Location = new Point(467, 392);
            kitapEkle.Name = "kitapEkle";
            kitapEkle.Size = new Size(94, 29);
            kitapEkle.TabIndex = 4;
            kitapEkle.Text = "Ekle";
            kitapEkle.UseVisualStyleBackColor = true;
            kitapEkle.Click += kitapEkle_Click;
            // 
            // anasayfa
            // 
            anasayfa.Location = new Point(673, 382);
            anasayfa.Name = "anasayfa";
            anasayfa.Size = new Size(89, 39);
            anasayfa.TabIndex = 6;
            anasayfa.Text = "Anasayfa";
            anasayfa.UseVisualStyleBackColor = true;
            anasayfa.Click += anasayfa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(662, 358);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // KitapListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 451);
            Controls.Add(dataGridView1);
            Controls.Add(anasayfa);
            Controls.Add(kitapEkle);
            Controls.Add(kitapSil);
            Name = "KitapListesi";
            Text = "KitapListesi";
            Load += KitapListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button kitapSil;
        private Button kitapEkle;
        private Button anasayfa;
        private DataGridView dataGridView1;
    }
}