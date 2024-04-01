using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kutuphane
{
    public partial class UyeBilgisiDuzenle : Form
    {
        private static string server = "185.255.92.151"; // Sunucu adı veya IP adresi
        private static string database = "kutuphane"; // Veritabanı adı
        private static string username = "root"; // Kullanıcı adı
        private static string password = "i9hmndzrsgptt26"; // Şifre
        private static string connectionString = $"server={server};database={database};user={username};password={password};";
        public string Ad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }
        public string Cinsiyet { get; set; }
        public string Unvan { get; set; }
        public string Id {  get; set; }
        public UyeBilgisiDuzenle(string id, string mAd, string kullaniciAdi, string soyad, string yas, string cinsiyet, string unvan)
        {
            this.Ad = mAd;
            this.KullaniciAdi = kullaniciAdi;
            this.Soyad = soyad;
            this.Yas = yas;
            this.Cinsiyet = cinsiyet;
            this.Unvan = unvan;
            this.Id = id;
            InitializeComponent();
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            KutuphanemPanel kutuphanemPanel = new KutuphanemPanel();
            kutuphanemPanel.Show();
            Hide();
        }

        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void UyeBilgisiDuzenle_Load(object sender, EventArgs e)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT kit.id, kit.kitapAdi, kit.yazar  FROM ((teslim_verilen_kitaplar AS tvk INNER JOIN kullanicilar AS kul ON kul.id = tvk.teslim_alan_kisi_id) INNER JOIN kitaplar AS kit ON kit.id = tvk.kitap_id) WHERE tvk.teslim_alan_kisi_id = " + Id;


                DataTable dataTable = new DataTable();

              

                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection))
                {
                    
                    dataAdapter.Fill(dataTable);
                }

                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.RowHeadersVisible = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;

                dataGridView1.DataSource = dataTable;
            }

            txtAd.Text = Ad;
            txtKullaniciadi.Text = KullaniciAdi;
            txtSoyad.Text = Soyad;
            txtYas.Text = Yas;
            txtUnvan.Text = Unvan;
            if (Cinsiyet == "Kadın")
            {
                txtCinsiyet.SelectedIndex = 0;
            }

            if (Cinsiyet == "Erkek")
            {
                txtCinsiyet.SelectedIndex = 1;
            }

            if (Cinsiyet == "Belirtmek İstemiyor")
            {
                txtCinsiyet.SelectedIndex = 2;
            }
        }

        private void UyeSil_Click(object sender, EventArgs e)
        {


            string nickname = txtKullaniciadi.Text;
            string name = txtAd.Text;
            string surname = txtSoyad.Text;
            int old = Convert.ToInt32(txtYas.Text);
            string gender = txtCinsiyet.Text;
            string title = txtUnvan.Text;
            UyeBilgileriniSil(nickname, name, surname, old, gender, title);
        }
        private bool UyeBilgileriniSil(string nickname, string name, string surname, int old, string gender, string title)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM kullanicilar WHERE kullaniciadi=@kullanici_adi AND Ad=@ad AND Soyad=@soyad AND Yas=@yas AND Cinsiyet=@cinsiyet AND Unvan=@Unvan";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@kullanici_adi", nickname);
                    cmd.Parameters.AddWithValue("@ad", name);
                    cmd.Parameters.AddWithValue("@soyad", surname);
                    cmd.Parameters.AddWithValue("@yas", old);
                    cmd.Parameters.AddWithValue("@cinsiyet", gender);
                    cmd.Parameters.AddWithValue("@unvan", title);

                    long result = (long)cmd.ExecuteScalar();

                }


            }
            return true;
        }

        private void UyeDuzenle_Click(object sender, EventArgs e)
        {

        }

        public void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtKullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtUnvan_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtYas_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
