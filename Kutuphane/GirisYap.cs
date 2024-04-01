using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace Kutuphane
{
    public partial class GirisYap : Form
    {
        public static string ID = "0";
        public GirisYap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {


            string kullaniciadi = txtKullaniciadi.Text;
            string sifre = txtSifre.Text;

            if (KullaniciGirisKontrol(kullaniciadi, sifre))
            {
               
                KutuphanemPanel form2 = new KutuphanemPanel();
                form2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Hatalý þifre yada kullanýcý adý");
            }


        }

        private bool KullaniciGirisKontrol(string kullaniciadi, string sifre)
        {
            string server = "185.255.92.151"; // Sunucu adý veya IP adresi
            string database = "kutuphane"; // Veritabaný adý
            string username = "root"; // Kullanýcý adý
            string password = "i9hmndzrsgptt26"; // Þifre


            string connectionString = $"server={server};database={database};user={username};password={password};";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id FROM kullanicilar WHERE kullanici_adi = '" + kullaniciadi + "' AND sifre = '" + sifre + "'";
                MessageBox.Show("SQLe baðlandý");
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ID = reader.GetInt32(0).ToString();
                            return true;
                        }
                    }
                    
                }
               return false; 
            }
            

        }


        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
