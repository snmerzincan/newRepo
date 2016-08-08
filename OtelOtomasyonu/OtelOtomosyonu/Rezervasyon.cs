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
    class Rezervasyon
    {
        private int _calisanID;
        private int _musteriID;
        private DateTime _girisTarihi;
        private DateTime _cikisTarihi;
        private DateTime _rezervasyonTarihi;
        private int _odaID;
        private int _odaNumarasi;
        private decimal _tutar;
        private decimal _onOdeme;
        private decimal _kalan;
        private bool _durum;

        

        #region Properties

        public int CalisanID
        {
            get { return _calisanID; }
            set { _calisanID = value; }
        }

        public int MusteriID
        {
            get { return _musteriID; }
            set { _musteriID = value; }
        }

        public DateTime GirisTarihi
        {
            get { return _girisTarihi; }
            set { _girisTarihi = value; }
        }

        public DateTime CikisTarihi
        {
            get { return _cikisTarihi; }
            set { _cikisTarihi = value; }
        }

        public DateTime RezervasyonTarihi
        {
            get { return _rezervasyonTarihi; }
            set { _rezervasyonTarihi = value; }
        }

        public int OdaID
        {
            get { return _odaID; }
            set { _odaID = value; }
        }

        public int OdaNumarasi
        {
            get { return _odaNumarasi; }
            set { _odaNumarasi = value; }
        }

        public decimal Tutar
        {
            get { return _tutar; }
            set { _tutar = value; }
        }

        public decimal OnOdeme
        {
            get { return _onOdeme; }
            set { _onOdeme = value; }
        }

        public decimal Kalan
        {
            get { return _kalan; }
            set { _kalan = value; }
        }

        public bool Durum
        {
            get { return _durum; }
            set { _durum = value; }
        }

        #endregion



        SqlConnection conn = new SqlConnection(Genel.connStr);

        public bool RezervasyonEkle(Rezervasyon r)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Satislar (CalisanID,MusteriID,GirisTarihi,CikisTarihi,RezervasyonTarihi,OdaID,OdaNo,Tutar,OnOdeme,Kalan,Durum) values (@CalisanID,@MusteriID,@GirisTarihi,@CikisTarihi,@RezervasyonTarihi,@OdaID,@OdaNo,@Tutar,@OnOdeme,@Kalan,@Durum)", conn);
            comm.Parameters.Add("@CalisanID", SqlDbType.Int).Value = r._calisanID;
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = r._musteriID;
            comm.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = r._girisTarihi;
            comm.Parameters.Add("@CikisTarihi", SqlDbType.DateTime).Value = r._cikisTarihi;
            comm.Parameters.Add("@RezervasyonTarihi", SqlDbType.DateTime).Value = r._rezervasyonTarihi;
            comm.Parameters.Add("@OdaID", SqlDbType.Int).Value = r._odaID;
            comm.Parameters.Add("@OdaNo", SqlDbType.Int).Value = r._odaNumarasi;
            comm.Parameters.Add("@Tutar", SqlDbType.Int).Value = r._tutar;
            comm.Parameters.Add("@OnOdeme", SqlDbType.Int).Value = r._onOdeme;
            comm.Parameters.Add("@Kalan", SqlDbType.Int).Value = r._kalan;
            comm.Parameters.Add("@Durum", SqlDbType.Int).Value = r._durum;

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
        public bool CheckOut(Rezervasyon r)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Satislar set  Durum=@Durum where(MusteriID=@MusteriID,OdaID=@OdaID", conn);
            
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = r._musteriID;
            comm.Parameters.Add("@OdaID", SqlDbType.Int).Value = r._odaID;
            comm.Parameters.Add("@Durum", SqlDbType.Int).Value = r._durum;

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


        //public int FiyatGetir(ComboBox odatip,TextBox fiyat) 
        //{
        //    int tutar = 0;
        //    SqlCommand comm = new SqlCommand("select Fiyat from OdaTipleri where OdaTipi=@OdaTipi", conn);
        //    comm.Parameters.Add("@OdaTipi",SqlDbType.VarChar).Value=odatip.SelectedItem.ToString();

        //    fiyat.Text = comm.ExecuteScalar().ToString() ;
        //    return tutar;


        //}
        public double FiyatGetir(ComboBox cmb)
        {
            double tutar = 0;
            SqlCommand comm = new SqlCommand("select Fiyat from OdaTipleri where OdaTipi=@OdaTipi", conn);
            comm.Parameters.Add("@OdaTipi", SqlDbType.VarChar).Value = cmb.SelectedItem;
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    tutar = Convert.ToDouble(comm.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    string s = ex.Message;

                }
                finally
                {

                    conn.Close();
                }
            }


            return tutar;


        }

    }
}
