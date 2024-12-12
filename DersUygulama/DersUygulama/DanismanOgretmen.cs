using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DersUygulama
{
    public partial class DanismanOgretmen : Form
    {
        private DatabaseHelper dbHelper;
        private int selectedSecimID = -1;  

        public DanismanOgretmen()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=DersSecimSistemi;Integrated Security=True;Encrypt=False";
            dbHelper = new DatabaseHelper(connectionString);  
        }

        private void DanismanOgretmen_Load(object sender, EventArgs e)
        {
            this.ogrenciDersSecimTableAdapter.Fill(this.dersSecimSistemiDataSet2.OgrenciDersSecim);
            LoadIstekler();
        }

      
        private void LoadIstekler()
        {
          
        }

      
        private void txtsecimid_TextChanged(object sender, EventArgs e)
        {
          
            if (int.TryParse(txtsecimid.Text, out int secimID))
            {
                selectedSecimID = secimID;  
                LoadIstekDetails(selectedSecimID);
            }
            else
            {
                selectedSecimID = -1;  
            }
        }

      
        private void LoadIstekDetails(int secimID)
        {
            var istek = dbHelper.GetDersSecimIstekByID(secimID);
            if (istek != null)
            {
           
                txtsecimid.Text = istek.SecimID.ToString();
                ogrenciid.Text = istek.OgrenciID.ToString();
                dersid.Text = istek.DersID.ToString();
                durum.Text = istek.Durum;
            }
            else
            {
                MessageBox.Show("Başvuru bulunamadı.");
            }
        }

        private void isteğiseç_Click(object sender, EventArgs e)
        {
            if (selectedSecimID != -1)
            {
                MessageBox.Show($"Başvuru {selectedSecimID} seçildi.");
                btnOnayla.Enabled = true;
                btnReddet.Enabled = true;
            }
            else
            {
                MessageBox.Show("Geçerli bir SecimID giriniz.");
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (selectedSecimID != -1)
            {
                dbHelper.OnaylaIstek(selectedSecimID);  
                MessageBox.Show($"Başvuru {selectedSecimID} onaylandı.");
                LoadIstekler();  
            }
            else
            {
                MessageBox.Show("Lütfen önce geçerli bir başvuru seçin.");
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (selectedSecimID != -1)
            {

                string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=DersSecimSistemi;Integrated Security=True;Encrypt=False";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        DELETE FROM OgrenciDersSecim
                        WHERE SecimID = @SecimID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SecimID", selectedSecimID); 

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Başvuru {selectedSecimID} reddedildi ve silindi.");
                        LoadIstekler(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce geçerli bir başvuru seçin.");
            }
        }
    }
}
