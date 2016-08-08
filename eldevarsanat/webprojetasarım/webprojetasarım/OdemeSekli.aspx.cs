using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webprojetasarım.DataModel;

namespace webprojetasarım
{

    public partial class OdemeYontemi : System.Web.UI.Page
    {
        SETEKwebprojeEntities ent = new SETEKwebprojeEntities();
        Models.SepetIslem sepet = new Models.SepetIslem();
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            if (!IsPostBack)
            {
                if (Session["kullaniciAdi"] != null)
                {
                    DataTable dt = (DataTable)Session["Sepet"];
                    string kid = Session["kullaniciAdi"].ToString();

                    var kullanıcı = (from k in ent.Kullanicilar
                                     where k.KullaniciAdi == kid
                                     select k).FirstOrDefault();
                    lbladi.Text = kullanıcı.Ad;
                    lblSoyadi.Text = kullanıcı.Soyad;
                    lblTutar.Text = ToplamTutarBul().ToString();
                }
                else
                {
                    Response.Redirect("FaturaBilgileri.aspx");
                }
            }
        }

        private decimal ToplamTutarBul()
        {
            decimal tutar = 0;
            DataTable dt = (DataTable)Session["Sepet"];

            foreach (DataRow dr in dt.Rows)
            {
                tutar += Convert.ToInt32(dr["Tutar"]);
            }
            return tutar;
        }
        private int ToplamAdetBul()
        {
            int tadet = 0;
            DataTable dt = (DataTable)Session["Sepet"];

            foreach (DataRow dr in dt.Rows)
            {
                tadet += Convert.ToInt32(dr["Adet"]);
            }
            return tadet;
        }



        protected void btndevam_Click(object sender, EventArgs e)
        {
            //Session.Remove("sepet");
            DataTable dt = (DataTable)Session["Sepet"];

            DataModel.Siparisler siparis = new DataModel.Siparisler();
            var firmaID = (from f in ent.Firmalar
                           where f.Silindi == false
                           select f).FirstOrDefault();

            //  var urunID = (from u in ent.Urunler
            //                where u.UrunID == siparis.UrunID
            //                select u).FirstOrDefault();

            //  siparis.Tarih = DateTime.Now;
            //  siparis.TeslimTarihi = DateTime.Now.AddDays(3);
            //  string Ad = Session["kullaniciAdi"].ToString();
            //  var ID = (from i in ent.Kullanicilar
            //            where i.KullaniciAdi == Ad
            //            select i).FirstOrDefault();
            //  siparis.KullaniciID = Convert.ToInt32(ID.KullaniciID);
            //  siparis.UrunID = Convert.ToInt32(urunID);
            //  siparis.Tutar = ToplamTutarBul();
            //  siparis.Miktar = ToplamAdetBul();
            //  siparis.FirmaID = firmaID.FirmaID;
            //  siparis.UrunAd = urunID.UrunAd;
            ////  siparis.durumu = (byte)Models.cEnum.SatisDurumu.siparis;
            //  ent.Siparisler.Add(siparis);
            //  ent.SaveChanges();
            //  //Yapılan satışa (satisno)ait satiş detayları sepetten kayıt edilecek.

            bool sonuc = false;
            foreach (DataRow dr in dt.Rows)
            {

                siparis.Miktar = Convert.ToInt32(dr["Adet"]);
                siparis.UrunID = Convert.ToInt32(dr["UrunID"]);
                siparis.Tutar = Convert.ToDecimal(dr["Tutar"]);
                siparis.Fiyat = Convert.ToDecimal(dr["Fiyat"]);
                siparis.UrunAd = dr["UrunAd"].ToString();
                siparis.Tarih = DateTime.Now;
                siparis.TeslimTarihi = DateTime.Now.AddDays(3);
                var urunID = (from u in ent.Urunler
                              where u.UrunID == siparis.UrunID
                              select u).FirstOrDefault();
                siparis.FirmaID = urunID.FirmaID;
                string Ad = Session["kullaniciAdi"].ToString();
                var ID = (from i in ent.Kullanicilar
                          where i.KullaniciAdi == Ad
                          select i).FirstOrDefault();
                siparis.OdemeID = 1;
                siparis.KullaniciID = Convert.ToInt32(ID.KullaniciID);
              
                ent.Siparisler.Add(siparis);
                sonuc = Convert.ToBoolean(ent.SaveChanges());
            }
                try
                {
                    if (sonuc)
                    {
                        DataTable dt1 = (DataTable)Session["sepet"];
                       
                            DataModel.SatisAnaliz detay = new DataModel.SatisAnaliz();
                            int SonSatisNo = ent.Siparisler.Where(s => s.KullaniciID == siparis.KullaniciID).ToList().Last().SiparisID;


                            detay.SiparisID = SonSatisNo;

                    detay.Adet = ToplamAdetBul();

                    detay.ToplamTutar = ToplamTutarBul();
                            detay.FirmaID = firmaID.FirmaID;
                            ent.SatisAnaliz.Add(detay);
                            ent.SaveChanges();
                      
                        Response.Redirect("TamamlananSiparis.aspx");
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            
        }
        protected void btncikis_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Anasayfa.aspx");
        }

        protected void btnKredikarti_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void btnhavaleeft_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }
    }
}