using Kutuphane;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Button_formları
{
    public partial class YeniUye : Form
    {
        private static string server = "185.255.92.151"; // Sunucu adı veya IP adresi
        private static string database = "kutuphane"; // Veritabanı adı
        private static string username = "root"; // Kullanıcı adı
        private static string password = "i9hmndzrsgptt26"; // Şifre
        private static string connectionString = $"server={server};database={database};user={username};password={password};";
        
        public YeniUye()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cinsiyettextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            KutuphanemPanel kutuphanemPanel = new KutuphanemPanel();
            kutuphanemPanel.Show();
            Hide();

        }

        private bool YeniUyeEkle(string uyeAdi,string kullaniciAdi, string soyad, int yas,string unvan, string cinsiyet,int sifre)
        {
            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO kullanicilar (kullanici_adi,ad,soyad,yas,unvan,cinsiyet,sifre) VALUES(@1,@2,@3,@4,@5,@6,@7)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@1", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@2",uyeAdi);
                    cmd.Parameters.AddWithValue("@3", soyad);
                    cmd.Parameters.AddWithValue("@4", yas);
                   cmd.Parameters.AddWithValue("@5", unvan);
                     cmd.Parameters.AddWithValue("@6", cinsiyet);
                    cmd.Parameters.AddWithValue("@7", sifre);

                    int result = (int)cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarı ile kaydedildi");
                }


            }
            return true;
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            string uyeAdi = txtAd.Text;
            string kullaniciAdi = txtKullaniciAdi.Text;
            string soyad = txtSoyad.Text;
            int yas = Convert.ToInt32(txtYas.Text);
            string unvan = txtUnvan.Text;
            string cinsiyet = txtCinsiyet.Text;
            int sifre = Convert.ToInt32(txtSifre.Text);
            YeniUyeEkle(uyeAdi,kullaniciAdi, soyad, yas,unvan, cinsiyet,sifre);
        }

        private void anasayfa_Click_1(object sender, EventArgs e)
        {
            KutuphanemPanel kutuphanemPanel = new KutuphanemPanel();
            kutuphanemPanel.Show();
            Hide();
        }

        private void uyeListesi_Click(object sender, EventArgs e)
        {
            UyeListesi uyeListesi = new UyeListesi();
            uyeListesi.Show();
            Hide();
        }

        private void txtYas_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
