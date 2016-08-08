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
    class cFilmTuru
    {
        private int _filmTurNo;
        private string _turAd;
        private string _aciklama;

        #region Properties
        public int FilmTurNo
        {
            get { return _filmTurNo; }
            set { _filmTurNo = value; }
        }

        public string TurAd
        {
            get { return _turAd; }
            set { _turAd = value; }
        }

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        } 
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void FilmTurleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from FilmTurleri where Silindi=0", conn);
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
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }
        //public void FilmTurleriGetir(ComboBox liste)
        //{
        //    liste.Items.Clear();
        //    SqlCommand comm = new SqlCommand("Select * from FilmTurleri where Silindi=0", conn);
        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    SqlDataReader dr = comm.ExecuteReader();
        //    if (dr.HasRows)
        //    {
        //        while (dr.Read())
        //        {
        //            liste.Items.Add(dr["TurAd"].ToString());
        //        }
        //    }
        //    dr.Close();
        //    conn.Close();
        //}
        public void FilmTurleriGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from FilmTurleri where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cFilmTuru ft = new cFilmTuru();
                    ft._filmTurNo = Convert.ToInt32(dr["FilmTurNo"]);
                    ft._turAd = dr["TurAd"].ToString();
                    liste.Items.Add(ft);
                }
            }
            dr.Close();
            conn.Close();
        }
        public bool FilmTuruGuncelle(int TurNo, string FilmTuru, string Aciklama)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update FilmTurleri Set TurAd=@TurAd, Aciklama=@Aciklama where FilmTurNo=@FilmTurNo", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = Aciklama;
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = TurNo;
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

        public bool FilmTuruSil(int TurNo)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update FilmTurleri Set Silindi=1 where FilmTurNo=@FilmTurNo", conn);
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = TurNo;
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

        public bool FilmTuruVarmi(string FilmTuru)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("select TurAd from FilmTurleri where Silindi=0 and TurAd=@TurAd", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                    Varmi = true;
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Varmi;
        }

        public bool FilmTuruEkle(string FilmTuru, string Aciklama)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into FilmTurleri (TurAd, Aciklama) values (@TurAd, @Aciklama)", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = Aciklama;
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
        public bool FilmTuruEkle(cFilmTuru ft)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into FilmTurleri (TurAd, Aciklama) values (@TurAd, @Aciklama)", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = ft._turAd;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = ft._aciklama;
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

        public int TurNoGetirByTureGore(string FilmTuru)
        {
            int TurNo = 0;
            SqlCommand comm = new SqlCommand("select FilmTurNo from FilmTurleri where TurAd=@TurAd and Silindi=0", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                TurNo = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return TurNo;
        }
        public override string ToString()
        {
                return TurAd;
        }
    }
}
