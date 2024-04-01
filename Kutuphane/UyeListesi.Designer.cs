namespace Kutuphane
{
    partial class UyeListesi
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
            uyeEkle = new Button();
            anasayfa = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uyeEkle
            // 
            uyeEkle.Location = new Point(621, 194);
            uyeEkle.Name = "uyeEkle";
            uyeEkle.Size = new Size(115, 31);
            uyeEkle.TabIndex = 3;
            uyeEkle.Text = "Yeni Üye Ekle";
            uyeEkle.UseVisualStyleBackColor = true;
            uyeEkle.Click += uyeEkle_Click;
            // 
            // anasayfa
            // 
            anasayfa.Location = new Point(642, 406);
            anasayfa.Name = "anasayfa";
            anasayfa.Size = new Size(123, 32);
            anasayfa.TabIndex = 20;
            anasayfa.Text = "Anasayfa";
            anasayfa.UseVisualStyleBackColor = true;
            anasayfa.Click += anasayfa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(551, 316);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UyeListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 513);
            Controls.Add(dataGridView1);
            Controls.Add(anasayfa);
            Controls.Add(uyeEkle);
            Name = "UyeListesi";
            Text = "UyeListesi";
            Load += UyeListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button uyeEkle;
        private Button anasayfa;
        private DataGridView dataGridView1;
    }
}