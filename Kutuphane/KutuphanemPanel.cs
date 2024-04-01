using Button_formları;
using kitap_ekle;
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
    public partial class KutuphanemPanel : Form
    {

        public KutuphanemPanel()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        { }

        private void Form2_Load(object sender, EventArgs e)
        { }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        { }

        private void kitapListele_Click(object sender, EventArgs e)
        {
            KitapListesi kitapListesi = new KitapListesi();
            kitapListesi.Show();
            Hide();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void uyeEkle_Click(object sender, EventArgs e)
        {
            YeniUye yeniUye = new YeniUye();
            yeniUye.Show();
            Hide();

        }

        private void uyeListesi_Click(object sender, EventArgs e)
        {
            UyeListesi uyeListesi = new UyeListesi();
            uyeListesi.Show();
            Hide();

        }

        private void teslimIslemleri_Click(object sender, EventArgs e)
        {
            Teslimİslemleri teslimİslemleri = new Teslimİslemleri();
            teslimİslemleri.Show();
            Hide();
        }

        private void kitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkleEkran kitapEkleEkran = new KitapEkleEkran();
            kitapEkleEkran.Show();
            Hide();
        }

        private void teslimAldığımKitaplar_Click(object sender, EventArgs e)
        {
           teslimAldıgımKitaplar teslimAldıgımKitaplar = new teslimAldıgımKitaplar();
            teslimAldıgımKitaplar.Show();
            Hide();
        }

        private void kitapListele2_Click(object sender, EventArgs e)
        {
            KitapListesi kitapListesi = new KitapListesi();
            kitapListesi.Show();
            Hide();










        }
    }
}
