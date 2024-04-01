namespace Kutuphane
{
    partial class Teslimİslemleri
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
            teslimEt = new Button();
            anasayfa = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // teslimEt
            // 
            teslimEt.BackColor = SystemColors.ControlLight;
            teslimEt.Location = new Point(416, 348);
            teslimEt.Name = "teslimEt";
            teslimEt.Size = new Size(89, 39);
            teslimEt.TabIndex = 2;
            teslimEt.Text = "Teslim Et";
            teslimEt.UseVisualStyleBackColor = false;
            teslimEt.Click += teslimEt_Click;
            // 
            // anasayfa
            // 
            anasayfa.Location = new Point(659, 394);
            anasayfa.Name = "anasayfa";
            anasayfa.Size = new Size(129, 44);
            anasayfa.TabIndex = 4;
            anasayfa.Text = "Anasayfa";
            anasayfa.UseVisualStyleBackColor = true;
            anasayfa.Click += anasayfa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(402, 310);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(492, 15);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(392, 307);
            dataGridView2.TabIndex = 6;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Teslimİslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 528);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(anasayfa);
            Controls.Add(teslimEt);
            Name = "Teslimİslemleri";
            Text = "Teslimİslemleri";
            Load += Teslimİslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button teslimEt;
        private Button anasayfa;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn KitapAdi;
        private DataGridViewTextBoxColumn Yazar;
        private DataGridViewTextBoxColumn Tur;
        private DataGridViewTextBoxColumn Yayinevi;
        private DataGridView dataGridView2;
    }
}