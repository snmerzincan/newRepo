using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webSaglikProjesi.Models
{
    
    public class cSepet
    {
        public DataTable YeniSepet()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("sepetID");
            dt.Columns["sepetID"].DataType = typeof(int); // turu belirtiyoruz
            dt.Columns["sepetID"].AutoIncrement = true;  //auto artsın
            dt.Columns["sepetID"].AutoIncrementSeed = 1; //1 den baslasın
            dt.Columns["sepetID"].AutoIncrementStep = 1; //1 er 1 er artsın

            dt.Columns.Add("urunID");
            dt.Columns["urunID"].DataType = typeof(int);

            dt.Columns.Add("urunAd");
            dt.Columns["urunAd"].DataType = typeof(string);

            dt.Columns.Add("adet");
            dt.Columns["adet"].DataType = typeof(int);
            dt.Columns["adet"].DefaultValue = 1;

            dt.Columns.Add("fiyat");
            dt.Columns["fiyat"].DataType = typeof(decimal);
            dt.Columns["fiyat"].DefaultValue = 0;

            dt.Columns.Add("tutar");
            dt.Columns["tutar"].DataType = typeof(int);
            dt.Columns["tutar"].DefaultValue = 0;

            return dt;
        }

    }
}