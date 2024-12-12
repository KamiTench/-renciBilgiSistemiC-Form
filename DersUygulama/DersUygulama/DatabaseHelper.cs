using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DersUygulama
{
    public partial class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper(string connString)
        {
            connectionString = connString;
        }


        public class DersSecimIstek
        {
            public int SecimID { get; set; }
            public int OgrenciID { get; set; }
            public int DersID { get; set; }
            public string IstekTuru { get; set; }
            public string Durum { get; set; }
        }
        public void AddDersSecimIstek(int ogrenciID, int dersID, string istekTuru)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
             
                string query = "INSERT INTO OgrenciDersSecim (OgrenciID, DersID, IstekTuru, Durum) " +
                               "VALUES (@OgrenciID, @DersID, @IstekTuru, 'Bekliyor')";

             
                SqlCommand cmd = new SqlCommand(query, conn);

          
                cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                cmd.Parameters.AddWithValue("@DersID", dersID);
                cmd.Parameters.AddWithValue("@IstekTuru", istekTuru);

           
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DersSecimIstek GetDersSecimIstekByID(int secimID)
        {
            DersSecimIstek istek = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SecimID, OgrenciID, DersID, IstekTuru, Durum FROM OgrenciDersSecim WHERE SecimID = @SecimID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SecimID", secimID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    istek = new DersSecimIstek
                    {
                        SecimID = Convert.ToInt32(reader["SecimID"]),
                        OgrenciID = Convert.ToInt32(reader["OgrenciID"]),
                        DersID = Convert.ToInt32(reader["DersID"]),
                        IstekTuru = reader["IstekTuru"].ToString(),
                        Durum = reader["Durum"].ToString()
                    };
                }
            }
            return istek;
        }
        public List<Ders> GetOgrenciDersler(int ogrenciID)
        {
            List<Ders> dersList = new List<Ders>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
           
                string query = @"
            SELECT D.DersID, D.DersAdi, D.DersKodu, D.Kredi, D.Kontenjan
            FROM OgrenciDersSecim OD
            INNER JOIN DersTablosu D ON OD.DersID = D.DersID
            WHERE OD.OgrenciID = @OgrenciID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);

           
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

           
                while (dr.Read())
                {
                    dersList.Add(new Ders
                    {
                        DersID = Convert.ToInt32(dr["DersID"]),
                        DersAdi = dr["DersAdi"].ToString(),
                        DersKodu = dr["DersKodu"].ToString(),
                        Kredi = Convert.ToInt32(dr["Kredi"]),
                        Kontenjan = Convert.ToInt32(dr["Kontenjan"])
                    });
                }
            }

            return dersList;
        }
        public class ÖğrenciBilgi
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public double GNO { get; set; }
        }


        public ÖğrenciBilgi GetOgrenciByID(int ogrenciID)
        {
            ÖğrenciBilgi ogrenci = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Ad, Soyad, GNO FROM OgrenciTablosu WHERE OgrenciID = @OgrenciID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);

             
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

          
                if (reader.Read())
                {
                    ogrenci = new ÖğrenciBilgi
                    {
                        Ad = reader["Ad"].ToString(),
                        Soyad = reader["Soyad"].ToString(),
                        GNO = Convert.ToDouble(reader["GNO"])
                    };
                }
            }

            return ogrenci;
        }
        public void AddDers(string dersAdi, string dersKodu, int kredi, int kontenjan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO DersTablosu (DersAdi, DersKodu, Kredi, Kontenjan) VALUES (@DersAdi, @DersKodu, @Kredi, @Kontenjan)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DersAdi", dersAdi);
                cmd.Parameters.AddWithValue("@DersKodu", dersKodu);
                cmd.Parameters.AddWithValue("@Kredi", kredi);
                cmd.Parameters.AddWithValue("@Kontenjan", kontenjan);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<Ders> GetDersler()
        {
            List<Ders> dersListesi = new List<Ders>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DersID, DersAdi, DersKodu, Kredi, Kontenjan FROM DersTablosu";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dersListesi.Add(new Ders
                    {
                        DersID = Convert.ToInt32(reader["DersID"]),
                        DersAdi = reader["DersAdi"].ToString(),
                        DersKodu = reader["DersKodu"].ToString(),
                        Kredi = Convert.ToInt32(reader["Kredi"]),
                        Kontenjan = Convert.ToInt32(reader["Kontenjan"])
                    });
                }
            }

            return dersListesi;
        }
        public List<ÖğrenciBilgi> GetOgrenciler()
        {
            List<ÖğrenciBilgi> ogrenciler = new List<ÖğrenciBilgi>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT OgrenciID, Ad, Soyad, GNO
            FROM OgrenciTablosu";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ogrenciler.Add(new ÖğrenciBilgi
                    {
                     
                        Ad = reader["Ad"].ToString(),
                        Soyad = reader["Soyad"].ToString(),
                        GNO = Convert.ToDouble(reader["GNO"])
                    });
                }
            }

            return ogrenciler;
        }


        public DataTable GetAllOgrenciler()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM OgrenciTablosu";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void AddOgrenci(string ad, string soyad, double gno)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO OgrenciTablosu (Ad, Soyad, GNO) VALUES (@Ad, @Soyad, @GNO)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@GNO", gno);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetAllDersler()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DersTablosu";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void OnaylaIstek(int secimID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                UPDATE OgrenciDersSecim
                SET Durum = 'Onaylandı'
                WHERE SecimID = @SecimID;
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SecimID", secimID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ReddetIstek(int secimID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                UPDATE OgrenciDersSecim
                SET Durum = 'Reddedildi'
                WHERE SecimID = @SecimID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SecimID", secimID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<DersSecimIstek> GetBekleyenIstekler()
        {
            List<DersSecimIstek> istekler = new List<DersSecimIstek>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SecimID, OgrenciID, DersID, IstekTuru, Durum FROM OgrenciDersSecim WHERE Durum = 'Bekliyor'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    istekler.Add(new DersSecimIstek
                    {
                        SecimID = Convert.ToInt32(reader["SecimID"]),
                        OgrenciID = Convert.ToInt32(reader["OgrenciID"]),
                        DersID = Convert.ToInt32(reader["DersID"]),
                        IstekTuru = reader["IstekTuru"].ToString(),
                        Durum = reader["Durum"].ToString()
                    });
                }
            }
            return istekler;
        }

        public Ders GetDersByID(int dersID)
        {
            Ders ders = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DersID, DersAdi, DersKodu, Kredi, Kontenjan FROM DersTablosu WHERE DersID = @DersID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DersID", dersID);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ders = new Ders
                    {
                        DersID = Convert.ToInt32(dr["DersID"]),
                        DersAdi = dr["DersAdi"].ToString(),
                        DersKodu = dr["DersKodu"].ToString(),
                        Kredi = Convert.ToInt32(dr["Kredi"]),
                        Kontenjan = Convert.ToInt32(dr["Kontenjan"])
                    };
                }
            }

            return ders;
        }
    }
}
