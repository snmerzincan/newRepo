using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfStokTakibi.Model
{
    class Cari
    {
        private int _cariNo;
        private string _unvan;
        private string _yetkili;
        private string _telefon;
        private string _adres;
        private string _ilce;
        private string _il;
        private string _vergiNo;
        private string _vergiDairesi;
        private double _toplamBorc;
        private double _toplamAlacak;
        private double _bakiye;

        #region Properties
        public int CariNo
        {
            get { return _cariNo; }
            set { _cariNo = value; }
        }
        private string _cariTipi;

        public string CariTipi
        {
            get { return _cariTipi; }
            set { _cariTipi = value; }
        }

        public string Unvan
        {
            get { return _unvan; }
            set { _unvan = value.Substring(0,1).ToLower() + value.Substring(1).ToUpper(); }
        }

        public string Yetkili
        {
            get { return _yetkili; }
            set { _yetkili = value.Substring(0, 1).ToLower() + value.Substring(1).ToUpper(); }
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

        public string Ilce
        {
            get { return _ilce; }
            set { _ilce = value; }
        }

        public string Il
        {
            get { return _il; }
            set { _il = value; }
        }

        public string VergiNo
        {
            get { return _vergiNo; }
            set { _vergiNo = value; }
        }

        public string VergiDairesi
        {
            get { return _vergiDairesi; }
            set { _vergiDairesi = value; }
        }

        public double ToplamBorc
        {
            get { return _toplamBorc; }
            set { _toplamBorc = value; }
        }

        public double ToplamAlacak
        {
            get { return _toplamAlacak; }
            set { _toplamAlacak = value; }
        }


        public double Bakiye
        {
            get { return _bakiye; }
            set { _bakiye = value; }
        } 
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public DataTable CarileriGetirByUnvanaGore(string UnvanaGore)
        {
            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cariler Where Silindi=0 and Unvan like @Unvan + '%'", conn);
            da.SelectCommand.Parameters.Add("@Unvan", SqlDbType.VarChar).Value = UnvanaGore;
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
        public DataTable CarileriGetirByCariTipi(string CariTipi)
        {
            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cariler Where Silindi=0 and CariTipi=@CariTipi", conn);
            da.SelectCommand.Parameters.Add("@CariTipi", SqlDbType.VarChar).Value = CariTipi;
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
        public DataTable CarileriGetir()
        {
            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cariler Where Silindi=0", conn);
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

        internal bool CariToplamlariGuncelle(int CariNo, double Borc, double Alacak)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Cariler Set ToplamBorc=ToplamBorc + @Borc, ToplamAlacak=ToplamAlacak + @Alacak where CariNo=@CariNo", conn);
            comm.Parameters.Add("@Borc", SqlDbType.Money).Value = Borc;
            comm.Parameters.Add("@Alacak", SqlDbType.Money).Value = Alacak;
            comm.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariNo;
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
        internal DataTable CarilerGetirByCariTipi(string CariTipi)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Unvan, CariTipi, Bakiye, ToplamBorc, ToplamAlacak, Ilce, Il, Yetkili, Telefon, CariNo from Cariler where Silindi=0 and CariTipi like @CariTipi + '%' order by Unvan", conn);
            da.SelectCommand.Parameters.Add("@CariTipi", SqlDbType.VarChar).Value = CariTipi;
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
