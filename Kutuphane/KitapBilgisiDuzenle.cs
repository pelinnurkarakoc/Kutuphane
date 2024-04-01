using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kutuphane
{
    public partial class KitapBilgisiDuzenle : Form
    {
        private static string server = "185.255.92.151"; // Sunucu adı veya IP adresi
        private static string database = "kutuphane"; // Veritabanı adı
        private static string username = "root"; // Kullanıcı adı
        private static string password = "i9hmndzrsgptt26"; // Şifre
        private static string connectionString = $"server={server};database={database};user={username};password={password};";
        public string Id { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string Tur { get; set; }
        public string Yayinevi { get; set; }
        public KitapBilgisiDuzenle(string id, string kitap, string yazar, string tur, string yayinevi)
        {

            this.Id = id;
            this.KitapAdi = kitap;
            this.Yazar = yazar;
            this.Tur = tur;
            this.Yayinevi = yayinevi;
            InitializeComponent();
        }
        private void anasayfa_Click(object sender, EventArgs e)
        {
            KutuphanemPanel kutuphanemPanel = new KutuphanemPanel();
            kutuphanemPanel.Show();
            Hide();
        }

        private void KitapBilgisiDuzenle_Load(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KitapDuzenle_Click(object sender, EventArgs e)
        {

        }

        private void kitapSil_Click(object sender, EventArgs e)
        {
            string bookName = txtKitapAdi.Text;
            string author = txtYazar.Text;
            string type = txtTur.Text;
            string publisher = txtYayinevi.Text;

            KitapBilgileriniSil(bookName, author, type, publisher); 
        }
        private bool KitapBilgileriniSil(string bookName, string author, string type, string publisher)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM kitaplar WHERE @kitapAdi AND @yazar AND @tur AND @yayinevi";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@kitapAdi",bookName);
                    cmd.Parameters.AddWithValue("@yazar",author);
                    cmd.Parameters.AddWithValue("@tur",type);
                    cmd.Parameters.AddWithValue("@yayinevi",publisher);


                    long result = (long)cmd.ExecuteScalar();

                }
                
            }
            return true;
        }
    }
}
