namespace Kutuphane
{
    partial class GirisYap
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
            loginButton = new Button();
            baslik = new Label();
            txtKullaniciadi = new TextBox();
            txtSifre = new TextBox();
            Label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(207, 315);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(138, 61);
            loginButton.TabIndex = 0;
            loginButton.Text = "Giriş Yap";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // baslik
            // 
            baslik.AutoSize = true;
            baslik.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            baslik.Location = new Point(193, 9);
            baslik.Name = "baslik";
            baslik.Size = new Size(281, 50);
            baslik.TabIndex = 2;
            baslik.Text = "KÜTÜPHANEM";
            // 
            // txtKullaniciadi
            // 
            txtKullaniciadi.Location = new Point(264, 118);
            txtKullaniciadi.Name = "txtKullaniciadi";
            txtKullaniciadi.Size = new Size(247, 27);
            txtKullaniciadi.TabIndex = 3;
            txtKullaniciadi.Text = "pelinnur";
            txtKullaniciadi.TextChanged += textBox1_TextChanged;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(264, 210);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(247, 27);
            txtSifre.TabIndex = 4;
            txtSifre.Text = "12345";
            txtSifre.TextChanged += textBox2_TextChanged;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(156, 217);
            Label2.Name = "Label2";
            Label2.Size = new Size(42, 20);
            Label2.TabIndex = 6;
            Label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 125);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 7;
            label1.Text = "Kullanıcı Adı:";
            // 
            // GirisYap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(659, 511);
            Controls.Add(label1);
            Controls.Add(Label2);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciadi);
            Controls.Add(baslik);
            Controls.Add(loginButton);
            MaximizeBox = false;
            Name = "GirisYap";
            Text = "Kütüphanem Giriş";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Label baslik;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Label Label2;
        private Label label1;
        private TextBox txtKullaniciadi;
    }
}
