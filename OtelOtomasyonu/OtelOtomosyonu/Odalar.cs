using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomosyonu
{
    class Odalar
    {
        SqlConnection conn = new SqlConnection(Genel.connStr);

        public static int Odanumarasi;

        private int _odaNumarasi;
        private bool _durum;

        public int OdaNumarasi
        {
            get { return _odaNumarasi; }
            set { _odaNumarasi = value; }
        }

        public bool Durum
        {
            get { return _durum; }
            set { _durum = value; }
        }




        public void OdaNoyaGoreOdaBilgileri(string OdaNumarası, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select OdaID,OdaNo,OdaKati,OdaDurumu,OdaTipi,YatakSayisi,OdaBuyukluk,OdaManzara,Fiyat,Aciklama from Odalar inner join OdaOzellikleri on Odalar.OdaOzID=OdaOzellikleri.OdaOzID inner join OdaTipleri on Odalar.OdaTipID=OdaTipleri.OdaTipID where @OdaNo=OdaNo", conn);
            comm.Parameters.Add("@OdaNo", SqlDbType.VarChar).Value = OdaNumarası;
            if (conn.State == ConnectionState.Closed) conn.Open();
            {

                int i = 0;
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        liste.Items.Add(dr["OdaID"].ToString());
                        liste.Items[i].SubItems.Add(dr["OdaNo"].ToString());
                        liste.Items[i].SubItems.Add(dr["OdaKati"].ToString());
                        liste.Items[i].SubItems.Add(dr["OdaDurumu"].ToString());
                        liste.Items[i].SubItems.Add(dr["OdaTipi"].ToString());
                        liste.Items[i].SubItems.Add(dr["YatakSayisi"].ToString());
                        liste.Items[i].SubItems.Add(dr["OdaBuyukluk"].ToString());
                        liste.Items[i].SubItems.Add(dr["OdaManzara"].ToString());
                        liste.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                        liste.Items[i].SubItems.Add(dr["Aciklama"].ToString());
                        i++;
                    }
                }
                dr.Close();
                conn.Close();
            }
        }


        public void OdaBilgileri(int OdaNumarası, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select OdaID,OdaNo,OdaKati,OdaDurumu,OdaTipi,YatakSayisi,Fiyat,Aciklama from Odalar inner join OdaOzellikleri on Odalar.OdaOzID=OdaOzellikleri.OdaOzID inner join OdaTipleri on Odalar.OdaTipID=OdaTipleri.OdaTipID where @OdaNo=OdaNo", conn);
            comm.Parameters.Add("@OdaNo", SqlDbType.Int).Value = OdaNumarası;
            if (conn.State == ConnectionState.Closed) conn.Open();
            {

                int i = 0;
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        liste.Items.Add(dr["OdaID"].ToString());
                        liste.Items[i].SubItems.Add(dr["OdaNo"].ToString());
                        liste.Items[i].SubItems.Add(dr["OdaKati"].ToString());
                        liste.Items[i].SubItems.Add(dr["OdaDurumu"].ToString());
                        liste.Items[i].SubItems.Add(dr["OdaTipi"].ToString());
                        liste.Items[i].SubItems.Add(dr["YatakSayisi"].ToString());
                        liste.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                        liste.Items[i].SubItems.Add(dr["Aciklama"].ToString());
                        i++;
                    }
                }
                dr.Close();
                conn.Close();
            }
        }

        //public void OdaBilgileriGüncelle(int OdaNumarası, ListView liste)
        //{
        //    liste.Items.Clear();
        //    SqlCommand comm = new SqlCommand("Update from Odalar inner join OdaOzellikleri on Odalar.OdaOzID=OdaOzellikleri.OdaOzID inner join OdaTipleri on Odalar.OdaTipID=OdaTipleri.OdaTipID set OdaNo=@OdaNo,OdaKati=@OdaKati,OdaDurumu=@OdaDurumu,OdaTipi=@OdaTipi,YatakSayisi=@YatakSayisi,Fiyat@Fiyat,Aciklama=@Aciklama where @OdaNo=OdaNo", conn);
        //    comm.Parameters.Add("@OdaNo", SqlDbType.Int).Value = OdaNumarası;
        //    comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = m._musteriID;
        //    comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = m._musteriAd;
        //    comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = m._musteriSoyad;
        //    comm.Parameters.Add("@MusteriTC", SqlDbType.VarChar).Value = m._tcNo;
        //    comm.Parameters.Add("@MusteriTelefon", SqlDbType.VarChar).Value = m._telefon;
        //    comm.Parameters.Add("@MusteriDogumTarihi", SqlDbType.DateTime).Value = m._dogumTarihi;
        //    comm.Parameters.Add("@MusteriEposta", SqlDbType.VarChar).Value = m._eMail;
        //    comm.Parameters.Add("@MusteriAdres", SqlDbType.VarChar).Value = m._adres;
        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    {

        //        int i = 0;
        //        SqlDataReader dr = comm.ExecuteReader();
        //        if (dr.HasRows)
        //        {
        //            while (dr.Read())
        //            {
        //                liste.Items.Add(dr["OdaID"].ToString());
        //                liste.Items[i].SubItems.Add(dr["OdaNo"].ToString());
        //                liste.Items[i].SubItems.Add(dr["OdaKati"].ToString());
        //                liste.Items[i].SubItems.Add(dr["OdaDurumu"].ToString());
        //                liste.Items[i].SubItems.Add(dr["OdaTipi"].ToString());
        //                liste.Items[i].SubItems.Add(dr["YatakSayisi"].ToString());
        //                liste.Items[i].SubItems.Add(dr["Fiyat"].ToString());
        //                liste.Items[i].SubItems.Add(dr["Aciklama"].ToString());
        //                i++;
        //            }
        //        }
        //        dr.Close();
        //        conn.Close();
        //    }
        //}


        public bool OdaDurumuGüncelle(Odalar o)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Odalar set OdaDurumu=@OdaDurumu where OdaNo=@OdaNumarasi", conn);
            comm.Parameters.Add("@OdaNumarasi", SqlDbType.Int).Value = o._odaNumarasi;
            comm.Parameters.Add("@OdaDurumu", SqlDbType.Bit).Value = o._durum;

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
        public void Aciklama(string OdaNumarası, TextBox Aciklama)
        {
            Aciklama.Clear();
            SqlCommand comm = new SqlCommand("select Aciklama from OdaOzellikleri inner join Odalar on OdaOzellikleri.OdaOzID=Odalar.OdaOzID where @OdaNo=OdaNo", conn);
            comm.Parameters.Add("@OdaNo", SqlDbType.VarChar).Value = OdaNumarası;
            if (conn.State == ConnectionState.Closed) conn.Open();
            {
                Aciklama.Text = comm.ExecuteScalar().ToString();
                conn.Close();
            }
        }

        public int BosOdaSayisi()
        {
            int sayi;
            SqlCommand comm = new SqlCommand("select Count(OdaDurumu) from Odalar where OdaDurumu='false'", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            sayi = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return sayi;
        }

        public int DoluOdaSayisi()
        {
            int sayi;
            SqlCommand comm = new SqlCommand("select Count(OdaDurumu) from Odalar where OdaDurumu='true'", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            sayi = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return sayi;
        }

        public int CikacakOdaSayisi()
        {
            int sayi = 0;
            SqlCommand comm = new SqlCommand("select Count(CikisTarihi) from Satislar where CikisTarihi=@tarih", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            comm.Parameters.Add("@tarih", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString();
            sayi = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return sayi;

        }

        public void CikacakListesi(ListBox lb)
        {
            SqlCommand comm = new SqlCommand("select OdaNo from Satislar where CikisTarihi=@tarih and Durum='True'", conn);
            comm.Parameters.Add("@tarih", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString();
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lb.Items.Add(dr["OdaNo"].ToString());
                    }

                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); }
        }



        public void OdaRenk(Button Odalar, int OdaNumarasi)
        {

            bool durum = false;
            SqlCommand comm = new SqlCommand("select OdaDurumu from Odalar where OdaNo=@OdaNo", conn);
            comm.Parameters.Add("@OdaNo", SqlDbType.Int).Value = OdaNumarasi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            durum = Convert.ToBoolean(comm.ExecuteScalar());
            //durum = comm.ExecuteScalar().ToString();
            if (durum == false)
            {
                Odalar.Image = Properties.Resources.BosOda;
            }
            else
            {
                Odalar.Image = Properties.Resources.DoluOda;
            }
            conn.Close();

        }

        public void CikarilacakOdaRenk(Button Odalar, int OdaNumarasi)
        {

            SqlCommand comm = new SqlCommand("select OdaNo from Satislar where CikisTarihi=@tarih and Durum='True'", conn);
            comm.Parameters.Add("@tarih", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString();

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                int OdaNo;

                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        OdaNo = Convert.ToInt32(dr["OdaNo"]);
                        if (OdaNo == OdaNumarasi)
                        {
                            Odalar.Image = Properties.Resources.CikacakOda;
                        }
                    }

                }

            }

            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); }
        }

    }

}







