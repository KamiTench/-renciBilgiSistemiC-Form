using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DersUygulama.DatabaseHelper;

namespace DersUygulama
{
    public partial class Öğrenci : Form
    {
        private DatabaseHelper dbHelper;

       
        public Öğrenci()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("Data Source=DESKTOP-UGRNDE4;Initial Catalog=DersSecimSistemi;Integrated Security=True;Encrypt=False");
        }

        


     
        private void LoadOgrenciDersler()
        {
            int ogrenciID = 1; 
            List<Ders> dersler = dbHelper.GetOgrenciDersler(ogrenciID);
            dataGridViewdersbilgileri.DataSource = dersler; 
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                int dersID = Convert.ToInt32(txtdersid.Text);

                if (ogrenciID <= 0)
                {
                    MessageBox.Show("Lütfen önce geçerli bir öğrenci seçin.");
                    return;
                }

                dbHelper.AddDersSecimIstek(ogrenciID, dersID, "Ekleme");
                MessageBox.Show("Ders ekleme isteğiniz danışman onayına gönderildi.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir DersID girin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                int dersID = Convert.ToInt32(txtdersid.Text);

                if (ogrenciID <= 0)
                {
                    MessageBox.Show("Lütfen önce geçerli bir öğrenci seçin.");
                    return;
                }

                dbHelper.AddDersSecimIstek(ogrenciID, dersID, "Silme");
                MessageBox.Show("Ders silme isteğiniz danışman onayına gönderildi.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir DersID girin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void Öğrenci_Load_1(object sender, EventArgs e)
        {
            this.ogrenciTablosuTableAdapter3.Fill(this.dersSecimSistemiDataSet3.OgrenciTablosu);
            this.ogrenciTablosuTableAdapter2.Fill(this.dersSecimSistemiDataSet2.OgrenciTablosu);
            this.ogrenciDersSecimTableAdapter1.Fill(this.dersSecimSistemiDataSet1.OgrenciDersSecim);
            this.ogrenciTablosuTableAdapter1.Fill(this.dersSecimSistemiDataSet.OgrenciTablosu);
            this.dersTablosuTableAdapter1.Fill(this.dersSecimSistemiDataSet2.DersTablosu);
            this.ogrenciTablosuTableAdapter.Fill(this.dersSecimSistemiDataSet1.OgrenciTablosu);
            this.ogrenciDersSecimTableAdapter.Fill(this.dersSecimSistemiDataSet.OgrenciDersSecim);

        }


        private void dersidbuton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int dersID = Convert.ToInt32(txtdersid.Text);

                    Ders ders = dbHelper.GetDersByID(dersID);

                    if (ders == null)
                    {
                        MessageBox.Show("Girilen DersID'ye ait ders bulunamadı.");
                        return;
                    }

                    txtdersadi.Text = ders.DersAdi;
                    derskod.Text = ders.DersKodu;
                    derskredisi.Text = ders.Kredi.ToString();
                    txtderskontenjan.Text = ders.Kontenjan.ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen geçerli bir DersID girin.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

        }


        private void txtdersid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void dataGridViewogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewdersbilgileri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtöğrenciİD_TextChanged(object sender, EventArgs e)
        {

        }

        private int ogrenciID; 

        private void ÖğrenciİDbuton_Click(object sender, EventArgs e)
        {
            try
            {
                ogrenciID = Convert.ToInt32(txtöğrenciİD.Text);

                ÖğrenciBilgi ogrenci = dbHelper.GetOgrenciByID(ogrenciID);

                if (ogrenci == null)
                {
                    MessageBox.Show("Girilen ÖğrenciID'ye ait öğrenci bulunamadı.");
                    return;
                }

                txtad.Text = ogrenci.Ad;
                txtsoyad.Text = ogrenci.Soyad;
                txtöğrencigno.Text = ogrenci.GNO.ToString("0.00"); 

                MessageBox.Show("Öğrenci bilgileri başarıyla yüklendi.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir ÖğrenciID girin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

    }

}
    

