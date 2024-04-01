using Kutuphane;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace kitap_ekle
{
    public partial class KitapEkleEkran : Form
    {
        private static string server = "185.255.92.151"; // Sunucu adý veya IP adresi
        private static string database = "kutuphane"; // Veritabaný adý
        private static string username = "root"; // Kullanýcý adý
        private static string password = "i9hmndzrsgptt26"; // Þifre
        private static string connectionString = $"server={server};database={database};user={username};password={password};";

   
        public KitapEkleEkran()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private bool KitapBilgisiEkle(string kitapEkle, string yazar, string tur, string yayinevi)
        {
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                 connection.Open();
                string query = "INSERT INTO kitaplar (kitapAdi,yazar,tur,yayinevi) VALUES(@kitapAdi, @yazar, @tur, @yayinevi)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@kitapAdi", kitapEkle);
                    cmd.Parameters.AddWithValue("@yazar", yazar);
                    cmd.Parameters.AddWithValue("@tur", tur);
                    cmd.Parameters.AddWithValue("@yayinevi", yayinevi);



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kitap baþarý ile kaydedildi");
                }


            }
            return true;
        }

        private void anasayfabutton_Click(object sender, EventArgs e)
        {
            KutuphanemPanel kutuphanemPanel = new KutuphanemPanel();
            kutuphanemPanel.Show();
            Hide();
        }

        private void kitapEkle_Click(object sender, EventArgs e)
        {
            string kitapEkle = txtKitapAdi.Text;
            string yazar = txtYazar.Text;
            string tur = txtTur.Text;
            string yayinevi = txtYayinevi.Text;
            KitapBilgisiEkle(kitapEkle, yazar, tur, yayinevi);


        }

        private void kitaplistesi_Click(object sender, EventArgs e)
        {
            KitapListesi kitapListesi = new KitapListesi();
            kitapListesi.Show();


        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
