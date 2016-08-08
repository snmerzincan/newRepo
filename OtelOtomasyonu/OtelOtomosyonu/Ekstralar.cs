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
    class Ekstralar
    {
        SqlConnection conn = new SqlConnection(Genel.connStr);

        public double EkstraFiyat(ComboBox cmb)
        {  
            double fiyat=0;
            try
            {
            SqlCommand comm = new SqlCommand("Select Fiyat from EkstraAktiviteler where EkstraAdi=@EkstraAdi",conn);
            comm.Parameters.Add("@EkstraAdi", SqlDbType.VarChar).Value = cmb.SelectedItem;
            if (conn.State == ConnectionState.Closed) conn.Open();
            {
                fiyat = Convert.ToDouble(comm.ExecuteScalar());
            }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
          
            conn.Close();
            return fiyat;
        
        }
        
             
    }
}
