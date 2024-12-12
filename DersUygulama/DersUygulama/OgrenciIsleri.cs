using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DersUygulama
{
    public partial class OgrenciIsleri : Form
    {
        private DatabaseHelper dbHelper;

        public OgrenciIsleri()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("Data Source=DESKTOP-UGRNDE4;Initial Catalog=DersSecimSistemi;Integrated Security=True;Encrypt=False");
        }

        private void OgrenciIsleri_Load(object sender, EventArgs e)
        {
            LoadOgrenciler();
            LoadDersler();
        }

        // Öğrenci Ekle
        private void btnOgrenciEkle_Click_1(object sender, EventArgs e)
        {
            string ad = txtOgrenciAd.Text;
            string soyad = txtOgrenciSoyad.Text;
            double gno = Convert.ToDouble(txtGNO.Text);

            dbHelper.AddOgrenci(ad, soyad, gno);

            MessageBox.Show("Öğrenci başarıyla eklendi.");
            LoadOgrenciler();
        }

        // Ders Ekle
        private void btnDersEkle_Click_1(object sender, EventArgs e)
        {
            // Formdaki ilgili alanlardan verileri alıyoruz
            string dersAdi = txtDersAdi.Text;
            string dersKodu = txtDersKodu.Text;
            int kredi = Convert.ToInt32(txtKredi.Text);
            int kontenjan = Convert.ToInt32(txtKontenjan.Text); // Kontenjan alanını ekledik

            // Ders ekleme işlemi
            dbHelper.AddDers(dersAdi, dersKodu, kredi, kontenjan);

            MessageBox.Show("Ders başarıyla eklendi.");

            // Dersleri yenileme
            LoadDersler();
        }


        // Öğrenci Listeleme
        private void LoadOgrenciler()
        {
            DataTable ogrenciler = dbHelper.GetAllOgrenciler();
            dgvOgrenciler.DataSource = ogrenciler;
        }

        // Ders Listeleme
        private void LoadDersler()
        {
            DataTable dersler = dbHelper.GetAllDersler();
            dgvDersler.DataSource = dersler;
        }

        private void txtKontenjan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDersRaporu_Click(object sender, EventArgs e)
        {
            var dersListesi = dbHelper.GetDersler();

            // Raporu listeleme (örneğin bir DataGridView veya ListBox kullanabilirsiniz)
            dgvDersler.DataSource = dersListesi;

            MessageBox.Show("Ders raporu başarıyla yüklendi.");
        }

        private void btnOgrenciRaporu_Click(object sender, EventArgs e)
        {
            var ogrenciListesi = dbHelper.GetOgrenciler();

            // Raporu listeleme (örneğin bir DataGridView veya ListBox kullanabilirsiniz)
            dgvOgrenciler.DataSource = ogrenciListesi;

            MessageBox.Show("Öğrenci raporu başarıyla yüklendi.");
        }

        private void dgvDersler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOgrenciler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
