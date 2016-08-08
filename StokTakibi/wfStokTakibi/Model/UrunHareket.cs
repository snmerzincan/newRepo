using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfStokTakibi.Model
{
    class UrunHareket
    {
        private int _hareketID;
        private DateTime _tarih;
        private string _islemTuru;
        private int _firmaID;
        private int _urunID;
        private string _birim;
        private string _belge;
        private double _birimFiyat;
        private int _adet;
        private double _tutar;

        #region Properties
        public int HareketID
        {
            get { return _hareketID; }
            set { _hareketID = value; }
        }

        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }

        public string IslemTuru
        {
            get { return _islemTuru; }
            set { _islemTuru = value; }
        }

        public int FirmaID
        {
            get { return _firmaID; }
            set { _firmaID = value; }
        }

        public int UrunID
        {
            get { return _urunID; }
            set { _urunID = value; }
        }

        public string Birim
        {
            get { return _birim; }
            set { _birim = value; }
        }

        public string Belge
        {
            get { return _belge; }
            set { _belge = value; }
        }

        public double BirimFiyat
        {
            get { return _birimFiyat; }
            set { _birimFiyat = value; }
        }

        public int Adet
        {
            get { return _adet; }
            set { _adet = value; }
        }


        public double Tutar
        {
            get { return _tutar; }
            set { _tutar = value; }
        } 
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void UrunHareketleriGetir(ListView liste, int UrunID)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select Tarih, IslemTuru, Unvan, Adet, BirimFiyat, Tutar, Belge, Birim, UrunID, FirmaID, HareketID from UrunHareketleri uh inner join Cariler c on uh.FirmaID=c.CariNo where uh.Silindi=0 and UrunID=@UrunID order by Tarih desc", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = UrunID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
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
                        liste.Items[i].SubItems.Add(dr[9].ToString());
                        liste.Items[i].SubItems.Add(dr[10].ToString());
                        i++;
                    }
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }
        public int UrunHareketEkle(UrunHareket uh)
        {
            //bool Sonuc = false;
            int sonkayitno = 0;
            SqlCommand comm = new SqlCommand("Insert into UrunHareketleri (Tarih, IslemTuru, FirmaID, UrunID, Birim, Belge, BirimFiyat, Adet) values (@Tarih, @IslemTuru, @FirmaID, @UrunID, @Birim, @Belge, @BirimFiyat, @Adet); Select Scope_IDENTITY()", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = uh._tarih;
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = uh._islemTuru;
            comm.Parameters.Add("@FirmaID", SqlDbType.Int).Value = uh._firmaID;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = uh._urunID;
            comm.Parameters.Add("@Birim", SqlDbType.VarChar).Value = uh._birim;
            comm.Parameters.Add("@Belge", SqlDbType.VarChar).Value = uh._belge;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = uh._birimFiyat;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = uh._adet;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonkayitno = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonkayitno;
        }
        public bool UrunHareketSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update UrunHareketleri Set Silindi=1 where HareketID=@HareketID", conn);
            comm.Parameters.Add("@HareketID", SqlDbType.Int).Value = ID;
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
    }
}
