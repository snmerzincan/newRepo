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
    class Personel
    {
        private string _persID;
        private string _persTC;
        private string _persAdi;
        private string _persSoyadi;
        private DateTime _dogumTarih;
        private string _dogumYeri;
        private bool _cinsiyet;
        private bool _medeniHal;
        private string _telefon;
        private string _email;
        private string _adres;
        private string _departman;

        #region Properties
        public string PersID
        {
            get { return _persID; }
            set { _persID = value; }
        }
        public string PersTC
        {
            get { return _persTC; }
            set { _persTC = value; }
        }
        public string PersAdi
        {
            get { return _persAdi; }
            set { _persAdi = value; }
        }
        public string PersSoyadi
        {
            get { return _persSoyadi; }
            set { _persSoyadi = value; }
        }
        public DateTime DogumTarih
        {
            get
            {
                return _dogumTarih;
            }
            set
            {
                _dogumTarih = value;
            }
        }
        public string DogumYeri
        {
            get
            {
                return _dogumYeri;
            }
            set
            {
                _dogumYeri = value;
            }
        }
        public bool Cinsiyet
        {
            get
            {
                return _cinsiyet;
            }
            set
            {
                _cinsiyet = value;
            }
        }
        public bool MedeniHal
        {
            get
            {
                return _medeniHal;
            }
            set
            {
                _medeniHal = value;
            }
        }
        public string Telefon
        {
            get
            {
                return _telefon;
            }
            set
            {
                _telefon = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string Adres
        {
            get
            {
                return _adres;
            }
            set
            {
                _adres = value;
            }
        }
        public string Departman
        {
            get
            {
                return _departman;
            }
            set
            {
                _departman = value;
            }
        }
        #endregion
        SqlConnection conn = new SqlConnection(Genel.connStr);

        //public bool PersonelVarmi(string PersonelTC)
        //{
        //    bool Varmi = false;
        //    SqlCommand comm = new SqlCommand("select TC from Calisanlar where TC=@TC", conn);
        //    comm.Parameters.Add("@TC", SqlDbType.VarChar).Value = PersonelTC;
        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    try
        //    {
        //        SqlDataReader dr = comm.ExecuteReader();
        //        if (dr.HasRows)
        //        {
        //            Varmi = true;
        //            dr.Close();
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        string hata = ex.Message;
        //    }
        //    finally { conn.Close(); }
        //    return Varmi;
        //}

        public bool PersonelEkle(Personel p)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Calisanlar (Ad, Soyad, TC, DogumTarihi, DogumYeri,Telefon, Adres, Email, Departman,Cinsiyet, MedeniHal) values (@Ad, @Soyad, @TC, @DTarih, @DogumYeri,@Telefon, @Adres, @Email, @Departman, @Cinsiyet, @MedeniHal)", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = p._persAdi;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = p._persSoyadi;
            comm.Parameters.Add("@TC", SqlDbType.VarChar).Value = p._persTC;
            comm.Parameters.Add("@DTarih", SqlDbType.DateTime).Value = p._dogumTarih;
            comm.Parameters.Add("@DogumYeri", SqlDbType.VarChar).Value = p._dogumYeri;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = p._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = p._adres;
            comm.Parameters.Add("@Email", SqlDbType.VarChar).Value = p._email;
            comm.Parameters.Add("@Departman", SqlDbType.VarChar).Value = p._departman;
            comm.Parameters.Add("@Cinsiyet", SqlDbType.Bit).Value = p._cinsiyet;
            comm.Parameters.Add("@MedeniHal", SqlDbType.Bit).Value = p._medeniHal;

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

        public bool PersonelleriGetir(ListView liste)
        {
            liste.Items.Clear();
            bool sonuc = false;
            int i = 0;
            SqlCommand comm = new SqlCommand("select * from Calisanlar where Departman='İdare' or Departman='Resepsiyon' and Yetki='True'", conn);

            if (conn.State == ConnectionState.Closed) conn.Open();
            {
               
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
                        liste.Items[i].SubItems.Add(dr[8].ToString());
                        liste.Items[i].SubItems.Add(dr[9].ToString());
                        liste.Items[i].SubItems.Add(dr[10].ToString());
                        liste.Items[i].SubItems.Add(dr[10].ToString());
                        i++;
                    }
                }
                catch (SqlException ex)
                {
                    string hata = ex.Message;
                }
                finally { conn.Close(); }

                return sonuc;
            }
        }
        
        
        public bool PersonelSil(Personel p)
        {
            bool sonuc = false;

            SqlCommand comm = new SqlCommand("delete from Calisanlar where CalisanID=@CalisanID", conn);

            comm.Parameters.Add("@CalisanID", SqlDbType.Int).Value = p._persID;


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

        public bool PersonelBilgileriGuncelle(Personel p)
        {
            bool Sonuc = false;

            SqlCommand comm = new SqlCommand("update Calisanlar set Ad=@Ad,Soyad=@Soyad,TC=@TC,DogumTarihi=@DTarih,DogumYeri=@DogumYeri,Telefon=@Telefon,Adres=@Adres,Email=@Email,Departman=@Departman,Cinsiyet=@Cinsiyet, MedeniHal=@MedeniHal where CalisanID=@CalisanID", conn);

            comm.Parameters.Add("@CalisanID", SqlDbType.Int).Value = p._persID;
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = p._persAdi;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = p._persSoyadi;
            comm.Parameters.Add("@TC", SqlDbType.VarChar).Value = p._persTC;
            comm.Parameters.Add("@DTarih", SqlDbType.DateTime).Value = p._dogumTarih;
            comm.Parameters.Add("@DogumYeri", SqlDbType.VarChar).Value = p._dogumYeri;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = p._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = p._adres;
            comm.Parameters.Add("@Email", SqlDbType.VarChar).Value = p._email;
            comm.Parameters.Add("@Departman", SqlDbType.VarChar).Value = p._departman;
            comm.Parameters.Add("@Cinsiyet", SqlDbType.Bit).Value = p._cinsiyet;
            comm.Parameters.Add("@MedeniHal", SqlDbType.Bit).Value = p._medeniHal;
            

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


        public void PersonelGetirDetayliSorgulama(string AdaGore, string SoyadaGore, string TCyeGore, string DepartmanaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Calisanlar where Ad like @Ad + '%' and Soyad like @Soyad + '%' and TC like @TC + '%' and Departman like @Departman + '%' and Yetki='True'", conn);


            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = AdaGore;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = SoyadaGore;
            comm.Parameters.Add("@TC", SqlDbType.VarChar).Value = TCyeGore;
            comm.Parameters.Add("@Departman", SqlDbType.VarChar).Value = DepartmanaGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int i = 0;
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        i++;
                    }
                    dr.Close();
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
