using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kutuphane
{
    public partial class teslimAldıgımKitaplar : Form
    {

        private static string server = "185.255.92.151"; // Sunucu adı veya IP adresi
        private static string database = "kutuphane"; // Veritabanı adı
        private static string username = "root"; // Kullanıcı adı
        private static string password = "i9hmndzrsgptt26"; // Şifre
        private static string connectionString = $"server={server};database={database};user={username};password={password};";
        public teslimAldıgımKitaplar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            KutuphanemPanel kutuphanem = new KutuphanemPanel();
            kutuphanem.Show();
        }



        private void teslimAldıgımKitaplar_Load(object sender, EventArgs e)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //
                string currentUserId = GirisYap.ID;
                string query = "SELECT kitaplar.kitapAdi, kitaplar.yazar,kitaplar.yayinevi FROM ((teslim_verilen_kitaplar INNER JOIN kullanicilar ON kullanicilar.id = teslim_verilen_kitaplar.teslim_alan_kisi_id) INNER JOIN kitaplar ON kitaplar.id = teslim_verilen_kitaplar.kitap_id) WHERE teslim_alan_kisi_id=" + currentUserId+";";
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kitapId;
            string kullaniciId;
        }
    }
}
