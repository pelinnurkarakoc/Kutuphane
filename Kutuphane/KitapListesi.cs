using kitap_ekle;
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
    public partial class KitapListesi : Form
    {
        private static string server = "185.255.92.151"; // Sunucu adı veya IP adresi
        private static string database = "kutuphane"; // Veritabanı adı
        private static string username = "root"; // Kullanıcı adı
        private static string password = "i9hmndzrsgptt26"; // Şifre
        private static string connectionString = $"server={server};database={database};user={username};password={password};";
       
        public KitapListesi()
        {
            InitializeComponent();


        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            KutuphanemPanel kutuphanemPanel = new KutuphanemPanel();
            kutuphanemPanel.Show();
            Hide();
        }

        private void kitapSil_Click(object sender, EventArgs e)
        {

        }


        private void KitapListesi_Load(object sender, EventArgs e)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id,kitapAdi, Yazar, Tur, Yayinevi FROM kitaplar";


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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string kitapAdi = row.Cells["kitapAdi"].Value.ToString();
                string yazar = row.Cells["yazar"].Value.ToString();
                string tur= row.Cells["tur"].Value.ToString();
                string yayinevi = row.Cells["yayinevi"].Value.ToString();
                string id = row.Cells["id"].Value.ToString();



                KitapBilgisiDuzenle kitapBilgisiDuzenle = new KitapBilgisiDuzenle(id,kitapAdi, yazar,tur,yayinevi);
                kitapBilgisiDuzenle.Show();
                Hide();
            }
        }

        private void kitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkleEkran kitapEkleEkran = new KitapEkleEkran();
            kitapEkleEkran.Show();
            Hide();
        }
    }


}



