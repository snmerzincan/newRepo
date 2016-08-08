using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfVideoMarketProjesi
{
    class cMusteri
    {
        private int _musteriNo;
        private string _musteriAd;
        private string _musteriSoyad;
        private string _telefon;
        private string _adres;

        #region Properties
        public int MusteriNo
        {
            get { return _musteriNo; }
            set { _musteriNo = value; }
        }

        public string MusteriAd
        {
            get { return _musteriAd; }
            set { _musteriAd = value; }
        }

        public string MusteriSoyad
        {
            get { return _musteriSoyad; }
            set { _musteriSoyad = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }


        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        } 
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void MusterileriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Musteriler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());             
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }
        public void MusterileriGetirBySorgulama(string AdaGore, string SoyadaGore, string TelefonaGore, string AdreseGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Musteriler where Silindi=0 and MusteriAd like @AdaGore + '%' and MusteriSoyad like @SoyadaGore + '%' and Telefon like @TelefonaGore + '%' and Adres like @AdreseGore + '%'", conn);
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = AdaGore;
            comm.Parameters.Add("@SoyadaGore", SqlDbType.VarChar).Value = SoyadaGore;
            comm.Parameters.Add("@TelefonaGore", SqlDbType.VarChar).Value = TelefonaGore;
            comm.Parameters.Add("@AdreseGore", SqlDbType.VarChar).Value = AdreseGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }
        public bool MusteriEkle(cMusteri m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Musteriler (MusteriAd, MusteriSoyad, Telefon, Adres) values (@MusteriAd, @MusteriSoyad, @Telefon, @Adres)", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = m._musteriAd;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = m._musteriSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = m._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = m._adres;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public bool MusteriGuncelle(cMusteri m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Musteriler set MusteriAd=@MusteriAd, MusteriSoyad=@MusteriSoyad, Telefon=@Telefon, Adres=@Adres where MusteriNo=@MusteriNo", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = m._musteriAd;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = m._musteriSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = m._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = m._adres;
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = m._musteriNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public bool MusteriSil(int MusteriNo)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Musteriler set Silindi=1 where MusteriNo=@MusteriNo", conn);
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = MusteriNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public bool MusteriVarmi(string Adi, string Soyadi)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("select MusteriAd from Musteriler where Silindi=0 and MusteriAd=@Ad and MusteriSoyad=@Soyad", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Adi;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = Soyadi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                    Varmi = true;
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Varmi;
        }
        public bool MusteriVarmi(string Adi, string Soyadi, string MusteriNo)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("select MusteriAd from Musteriler where Silindi=0 and MusteriAd=@Ad and MusteriSoyad=@Soyad and MusteriNo !=@MusteriNo", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Adi;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = Soyadi;
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = Convert.ToInt32(MusteriNo);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                    Varmi = true;
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Varmi;
        }
        public void MusterileriGetirByAdaGore(string AdaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Musteriler where Silindi=0 and MusteriAd like @AdaGore + '%'", conn);
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = AdaGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }
    }
}
