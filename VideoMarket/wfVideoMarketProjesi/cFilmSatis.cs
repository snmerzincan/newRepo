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
    class cFilmSatis
    {
        private int _satisNo;
        private DateTime _tarih;
        private int _filmNo;
        private int _musteriNo;
        private int _adet;
        private double _birimFiyat;

        #region Properties
        public int SatisNo
        {
            get { return _satisNo; }
            set { _satisNo = value; }
        }

        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }

        public int FilmNo
        {
            get { return _filmNo; }
            set { _filmNo = value; }
        }

        public int MusteriNo
        {
            get { return _musteriNo; }
            set { _musteriNo = value; }
        }

        public int Adet
        {
            get { return _adet; }
            set { _adet = value; }
        }

        public double BirimFiyat
        {
            get { return _birimFiyat; }
            set { _birimFiyat = value; }
        } 
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void SatislariGetir(ListView liste, TextBox ToplamAdet, TextBox ToplamTutar)
        {
            int TAdet = 0;
            double TTutar = 0;
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select SatisNo, Tarih, FilmAd, MusteriAd + ' ' + MusteriSoyad as Musteri, BirimFiyat, Adet, BirimFiyat * Adet as Tutar, fs.FilmNo, fs.MusteriNo from FilmSatis fs inner join Filmler f on fs.FilmNo=f.FilmNo inner join Musteriler m on fs.MusteriNo = m.MusteriNo where fs.Silindi=0 order by Tarih desc,SatisNo desc", conn);
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
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    liste.Items[i].SubItems.Add(dr[8].ToString());
                    TAdet += Convert.ToInt32(dr[5]);
                    TTutar += Convert.ToDouble(dr[6]);
                    i++;
                }
            }
            dr.Close();
            conn.Close();
            ToplamAdet.Text = TAdet.ToString();
            ToplamTutar.Text = TTutar.ToString();
        }
        public bool SatisEkle(cFilmSatis fs)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into FilmSatis (Tarih, FilmNo, MusteriNo, Adet, BirimFiyat) values (@Tarih, @FilmNo, @MusteriNo, @Adet, @BirimFiyat)", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = fs._tarih;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = fs._filmNo;
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = fs._musteriNo;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = fs._adet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = fs._birimFiyat;
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
        public bool SatisIptal(int SatisNo)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update FilmSatis Set Silindi=1 where SatisNo=@SatisNo", conn);
            comm.Parameters.Add("@SatisNo", SqlDbType.Int).Value = SatisNo;
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
        public DataTable SatislariGetirByTarihlerArasi(DateTime Tarih1, DateTime Tarih2)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Convert(Date, Tarih, 104) as IslemTarihi, MusteriAd + ' ' + MusteriSoyad as Musteri, FilmAd, BirimFiyat, Adet, Adet*BirimFiyat as Tutar from FilmSatis fs inner join Musteriler m on fs.MusteriNo=m.MusteriNo inner join Filmler f on fs.FilmNo = f.FilmNo where fs.Silindi=0 and Convert(Date, Tarih, 104) between Convert(Date, @Tarih1, 104) and Convert(Date, @Tarih2, 104) order by SatisNo desc", conn);
            da.SelectCommand.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = Tarih1;
            da.SelectCommand.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = Tarih2;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }
    }
}
