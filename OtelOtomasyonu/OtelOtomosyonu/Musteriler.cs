using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomosyonu
{
    class Musteriler
    {
        private int _musteriID;
        private string _musteriAd;
        private string _musteriSoyad;
        private string _tcNo;
        private string _telefon;
        private DateTime _dogumTarihi;
        private string _eMail;
        private string _adres;
      

        #region Properties


        public int MusteriID
        {
            get { return _musteriID; }
            set { _musteriID = value; }
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
        public string TcNo
        {
            get { return _tcNo; }
            set { _tcNo = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }

        public string EMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        #endregion


        SqlConnection conn = new SqlConnection(Genel.connStr);


        public bool MusteriEkle(Musteriler m)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Musteriler(MusteriAd,MusteriSoyad,MusteriTC,MusteriTelefon,MusteriDogumTarihi,MusteriEposta,MusteriAdres) values (@MusteriAd,@MusteriSoyad,@MusteriTC,@MusteriTelefon,@MusteriDogumTarihi,@MusteriEposta,@MusteriAdres)", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = m._musteriAd;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = m._musteriSoyad;
            comm.Parameters.Add("@MusteriTC", SqlDbType.VarChar).Value = m._tcNo;
            comm.Parameters.Add("@MusteriTelefon", SqlDbType.VarChar).Value = m._telefon;
            comm.Parameters.Add("@MusteriDogumTarihi", SqlDbType.DateTime).Value = m._dogumTarihi; 
            comm.Parameters.Add("@MusteriEposta", SqlDbType.VarChar).Value = m._eMail;
            comm.Parameters.Add("@MusteriAdres", SqlDbType.VarChar).Value = m._adres;

             
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return sonuc;
        }

        public bool MusterileriGetir(ListView liste)
        {
            bool Sonuc = false;
            int i = 0;
            SqlCommand comm = new SqlCommand("Select MusteriID,MusteriAd,MusteriSoyad,MusteriTC,MusteriTelefon from Musteriler ", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();

            try
            {
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
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return Sonuc;
        }

        public bool MusterilerinTumBilgileriniGetir(ListView liste)
        {
            liste.Items.Clear();
            bool Sonuc = false;
            int i = 0;
            SqlCommand comm = new SqlCommand("Select MusteriID,MusteriAd,MusteriSoyad,MusteriTC,MusteriTelefon,MusteriDogumTarihi,MusteriEposta,MusteriAdres from Musteriler ", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return Sonuc;
        }

        public void MusterileriGetirDetayliSorgulama(string AdaGore, string SoyadaGore, string TCyeGore, string TelefonaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Musteriler where MusteriAd like @MusteriAd + '%' and MusteriSoyad like @MusteriSoyad + '%' and MusteriTC like @MusteriTC + '%' and MusteriTelefon like @MusteriTelefon + '%'", conn);

            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = AdaGore;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = SoyadaGore;
            comm.Parameters.Add("@MusteriTC", SqlDbType.VarChar).Value = TCyeGore;
            comm.Parameters.Add("@MusteriTelefon", SqlDbType.VarChar).Value = TelefonaGore;

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
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;

                }

            }
            else
            {
                MessageBox.Show("Getirilecek veri bulunamadı");
            }
            dr.Close();
            conn.Close();
        }


        public void MusterileriGetirAdaGore(string AdaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Musteriler where MusteriAd like @MusteriAd + '%' ", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = AdaGore;
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
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }

            }

            dr.Close();
            conn.Close();

        }

        public void MusterileriGetirSoyadaGore(string SoyadaGore, ListView liste)
        {
            liste.Items.Clear();

            SqlCommand comm = new SqlCommand("select * from Musteriler where MusteriSoyad like @MusteriSoyad + '%'", conn);

            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = SoyadaGore;

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
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }

            }
            dr.Close();
            conn.Close();
        }
        public void MusterileriGetirTCyeGore(string TCyeGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Musteriler where MusteriTC like @MusteriTC + '%' ", conn);
            comm.Parameters.Add("@MusteriTC", SqlDbType.VarChar).Value = TCyeGore;


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
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }

            }

            dr.Close();
            conn.Close();
        }

        public bool MusteriBilgileriGuncelle(Musteriler m)
        {
            bool Sonuc = false;

            SqlCommand comm = new SqlCommand("update Musteriler set MusteriAd=@MusteriAd,MusteriSoyad=@MusteriSoyad,MusteriTC=@MusteriTC,MusteriTelefon=@MusteriTelefon,MusteriDogumTarihi=@MusteriDogumTarihi,MusteriEposta=@MusteriEposta,MusteriAdres=@MusteriAdres where MusteriID=@MusteriID", conn);

            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = m._musteriID;
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = m._musteriAd;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = m._musteriSoyad;
            comm.Parameters.Add("@MusteriTC", SqlDbType.VarChar).Value = m._tcNo;
            comm.Parameters.Add("@MusteriTelefon", SqlDbType.VarChar).Value = m._telefon;
            comm.Parameters.Add("@MusteriDogumTarihi", SqlDbType.DateTime).Value = m._dogumTarihi;
            comm.Parameters.Add("@MusteriEposta", SqlDbType.VarChar).Value = m._eMail;
            comm.Parameters.Add("@MusteriAdres", SqlDbType.VarChar).Value = m._adres;

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
        public bool MusteriSil(Musteriler m)
        {
            bool sonuc = false;

            SqlCommand comm = new SqlCommand("delete from Musteriler where MusteriID=@MusteriID", conn);

            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = m._musteriID;
            

            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return sonuc;
        
        
        
        }
       
    }

}