using Button_formları;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class UyeListesi : Form
    {

        private static string server = "185.255.92.151"; // Sunucu adı veya IP adresi
        private static string database = "kutuphane"; // Veritabanı adı
        private static string username = "root"; // Kullanıcı adı
        private static string password = "i9hmndzrsgptt26"; // Şifre
        private static string connectionString = $"server={server};database={database};user={username};password={password};";
        private MySqlConnection connection;

        public UyeListesi()
        {
            InitializeComponent();
        }
        private void PopulateDataGridView()
        {
            string query = "SELECT * FROM Kullanicilar";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void anasayfa_Click(object sender, EventArgs e)
        {
            KutuphanemPanel kutuphanemPanel = new KutuphanemPanel();
            kutuphanemPanel.Show();
            Hide(); 
        }

        public void UyeListesi_Load(object sender, EventArgs e)
        {

            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                
                string query = "SELECT id,kullanici_adi,Ad,Soyad,Yas,Cinsiyet,Unvan FROM kullanicilar";

               
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

        }

        private void uyeEkle_Click(object sender, EventArgs e)
        {
            YeniUye yeniUye = new YeniUye();
            yeniUye.Show();
            Hide();
        }


        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    string ad = row.Cells["Ad"].Value.ToString();
                    string soyad = row.Cells["Soyad"].Value.ToString();
                    string kullaniciAdi = row.Cells["kullanici_adi"].Value.ToString();
                    string unvan = row.Cells["unvan"].Value.ToString();
                    string yas = row.Cells["Yas"].Value.ToString();
                    string cinsiyet = row.Cells["Cinsiyet"].Value.ToString();
                    string id = row.Cells["id"].Value.ToString();
                    
                    

                    UyeBilgisiDuzenle form = new UyeBilgisiDuzenle(id,ad,kullaniciAdi,soyad,yas,cinsiyet,unvan);
                    form.Show();
                    Hide();
                }

            
        }
    }
}
