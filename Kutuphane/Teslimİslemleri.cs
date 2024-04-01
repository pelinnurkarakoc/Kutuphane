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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Kutuphane
{
    public partial class Teslimİslemleri : Form
    {
        private static string server = "185.255.92.151"; // Sunucu adı veya IP adresi
        private static string database = "kutuphane"; // Veritabanı adı
        private static string username = "root"; // Kullanıcı adı
        private static string password = "i9hmndzrsgptt26"; // Şifre
        private static string connectionString = $"server={server};database={database};user={username};password={password};";


        public Teslimİslemleri()
        {
            InitializeComponent();
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            KutuphanemPanel kutuphanemPanel = new KutuphanemPanel();
            kutuphanemPanel.Show();
            Hide();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Teslimİslemleri_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                string query = "SELECT * FROM kitaplar";


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


                string query2 = "SELECT id,kullanici_adi FROM kullanicilar WHERE unvan = 'uye'";

                DataTable dataTable2 = new DataTable();


                using (MySqlDataAdapter dataAdapter2 = new MySqlDataAdapter(query2, connection))
                {
                    dataAdapter2.Fill(dataTable2);
                }

                dataGridView2.ColumnHeadersVisible = true;
                dataGridView2.RowHeadersVisible = true;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.ReadOnly = true;
                dataGridView2.DataSource = dataTable2;

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teslimEt_Click(object sender, EventArgs e)
        {
            
            string sqlCommand = "INSERT INTO teslim_verilen_kitaplar (teslim_alan_kisi_id, kitap_id) VALUES (@kisiId, @verilenKitap)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                
                connection.Open();

                // İlk dataGridView'den seçili satırın verilerini alın
                string kitapId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();


                // İkinci dataGridView'den seçili satırın verilerini alın
                string kullaniciId = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                // SQL komutunu oluşturun
                using (MySqlCommand command = new MySqlCommand(sqlCommand, connection))
                {
                    // Parametreleri ekleme
                    command.Parameters.AddWithValue("@kisiId", kullaniciId);
                    command.Parameters.AddWithValue("@verilenkitap", kitapId);


                    // Komutu çalıştırma
                    command.ExecuteNonQuery();
                }

                // SQL bağlantısını kapatın
                connection.Close();
            }

            MessageBox.Show("Veriler başarıyla aktarıldı!");
        }

        private void geriAl_Click(object sender, EventArgs e)
        {
            }
    }
}
