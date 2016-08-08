using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class Adres : System.Web.UI.Page
    {
        DataModel.SaglikUrunleriEntities ent = new DataModel.SaglikUrunleriEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtemail.Focus();

            }
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            var kullanici = (from u in ent.Kullanicilar
                             where u.kullaniciad == txtemail.Text && u.sifre == txtsifre.Text && u.silindi == false
                             select u).FirstOrDefault(); //nesneye cevırıyor koleksıyon oldugu ıcın

            if (kullanici == null)
            {
                lblmesaj.Text = ("Kullanıcı adı veya şifre giriniz");
                txtemail.Focus();
            }
            else
            {
                lblmesaj.Text = ""; // onceden goruntulenen bır mesaj varsa temızler.
                Session["Kullanici"] = kullanici.id;
                pnladres.Visible = true;
                txtadres.Text = kullanici.adres;
                txtilce.Text = kullanici.ilce;
                txtIl.Text = kullanici.il;
                txtTelefon.Text = kullanici.telefon;
                txtadres.Focus();

            }
        }

        private int ToplamAdetBul()
        {
            int tadet = 0;
            DataTable dt = (DataTable)Session["Sepet"];

            foreach (DataRow dr in dt.Rows)
            {
                tadet += Convert.ToInt32(dr["adet"]);
            }
            return tadet;
        }

        private decimal ToplamTutarBul()
        {
            decimal ttutar = 0;
            DataTable dt = (DataTable)Session["Sepet"];

            foreach (DataRow dr in dt.Rows)
            {
                ttutar += Convert.ToInt32(dr["tutar"]);
            }
            return ttutar;
        }
        protected void btnAdresOnay_Click(object sender, EventArgs e)

        {
            if (txtadres.Text.Trim() != "")
            {
                //Teslim adres bilgileri güncellenecek.
                int degisenid = Convert.ToInt32(Session["kullanici"]);
                var degisen = (from user in ent.Kullanicilar
                               where user.id == degisenid
                               select user).FirstOrDefault();
                degisen.adres = txtadres.Text;
                degisen.ilce = txtilce.Text;
                degisen.il = txtIl.Text;
                degisen.telefon = txtTelefon.Text;
                ent.SaveChanges();
                try
                {
                    ent.SaveChanges();
                    lblmesaj.Text = "Adres bilgileriniz güncellendi.";
                    //Sepet detayları Satış ve satış detay dosyalarına atılacak.
                    DataModel.Satislar satis = new DataModel.Satislar();
                    satis.tarih = DateTime.Now;
                    satis.teslimtarihi = DateTime.Now.AddDays(3);
                    satis.kullanicino = Convert.ToInt32(Session["kullanici"]);
                    satis.tutar = ToplamTutarBul();
                    satis.miktar = ToplamAdetBul();
                    satis.durumu = (byte)Models.cEnum.SatisDurumu.siparis;
                    ent.Satislar.Add(satis);
                    ent.SaveChanges();
                    //Yapılan satışa (satisno) ait satiş detayları sepetten kayıt edilecek.
                    DataModel.SatisDetaylari detay = new DataModel.SatisDetaylari();
                    //detay.satisno = satis.satisno;
                    int SonSatisNo = ent.Satislar.Where(s => s.kullanicino == satis.kullanicino).ToList().Last().satisno;

                    DataTable dt = (DataTable)Session["sepet"];
                    foreach (DataRow urun in dt.Rows)
                    {
                        detay.satisno = SonSatisNo;
                        detay.urunid = Convert.ToInt32(urun["urunID"]);
                        detay.adet = Convert.ToInt32(urun["adet"]);
                        detay.birimfiyat = Convert.ToDecimal(urun["fiyat"]);
                        detay.tutar = Convert.ToDecimal(urun["tutar"]);
                        ent.SatisDetaylari.Add(detay);
                        ent.SaveChanges();
                    }

                    Response.Redirect("Odeme.aspx");
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                }
            }
            //if (txtadres.Text.Trim() != "")
            //{
            //    //Teslim adres bilgileri güncellenecek.
            //    int degisenid = Convert.ToInt32(Session["kullanici"]);
            //    var degisen = (from user in ent.Kullanicilar
            //                   where user.id == degisenid
            //                   select user).FirstOrDefault();

            //    degisen.adres = txtadres.Text;
            //    degisen.ilce = txtilce.Text;
            //    degisen.il = txtIl.Text;
            //    degisen.telefon = txtTelefon.Text;
            //    try
            //    {
            //        ent.SaveChanges();
            //        lblmesaj.Text = "Adres bilgileriniz güncellendi.";
            //        //sepet detayları satış ve satış detay

            //        DataModel.Satislar satis = new DataModel.Satislar();
            //        satis.tarih = DateTime.Now.AddDays(3);
            //        satis.kullanicino = Convert.ToInt32(Session["kullanici"]);
            //        satis.tutar = ToplamTutarBul();
            //        satis.miktar = ToplamAdetBul();
            //        satis.durumu = (byte)Models.cEnum.SatisDurumu.siparis;
            //        ent.Satislar.Add(satis);
            //        ent.SaveChanges();
            //        //Yapılan satışa (satisno) ait satis detayları sepetten kayıt edilecek.
            //        DataModel.SatisDetaylari detay = new DataModel.SatisDetaylari();
            //        //detay.satisno = satis.satisno;
            //        int SonSatisNo = ent.Satislar.Where(s => s.kullanicino == satis.kullanicino).ToList().Last().satisno; //satis.kullanicino = degisen id  de denilebilir
            //        //detay.satisno = SonSatisNo;

            //        DataTable dt = (DataTable)Session["Sepet"];
            //        foreach (DataRow urun in dt.Rows)
            //        {
            //            detay.satisno = SonSatisNo;
            //            detay.urunid = Convert.ToInt32(urun["urunID"]);
            //            detay.adet = Convert.ToInt32(urun["adet"]);
            //            detay.birimfiyat = Convert.ToDecimal(urun["fiyat"]);
            //            detay.tutar = Convert.ToDecimal(urun["tutar"]);
            //            ent.SatisDetaylari.Add(detay);
            //            ent.SaveChanges();
            //        }
            //        Response.Redirect("Odeme.aspx");
            //    }
            //    catch (Exception ex)
            //    {
            //        string hata = ex.Message;
            //    }
            //}

        }

        protected void cbxUnuttum_CheckedChanged(object sender, EventArgs e)
        {
            if (txtemail.Text.Trim() != "")
               
            {
                DataModel.Kullanicilar k = EmailKontrol(txtemail.Text);
                
                if (k !=null)
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("Wissendeneme@gmail.com", "Wissen Ms-Yaz-10", System.Text.Encoding.UTF8);
                    mail.To.Add(txtemail.Text);
                    //mail.CC.Add(); Diğer göndermek istediğiniz adresleri ekleyebilirsiniz.
                    mail.Subject = "Sağlık Ürünleri E-Ticaret Sitesi";
                    //mail.Body = "Sayın , " + k.ad + " " + k.soyad + "<br/> Şifreniz : " + k.sifre;
                    StringBuilder sbMesaj = new StringBuilder();
                    sbMesaj.Append("Sayın , " + k.ad + " " + k.soyad + "<br/> Şifreniz : " + k.sifre + "<br/>");
                    sbMesaj.Append("<a href=\"" + Request.Url.Host + "/Adres.aspx\" > Alışverişe devam etmek için tıklayınız...</a>");                           //geldiği sayfanın adresini tutar
                    mail.Body = sbMesaj.ToString();
                    mail.IsBodyHtml = true;



                    SmtpClient sc = new SmtpClient();
                    sc.Host = "smtp.gmail.com";//mail.domain.com
                    sc.Port = 587;
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential("wissendeneme@gmail.com" , "wissen123");
                    try
                    {
                        sc.Send(mail);
                        lblmesaj.Text = "Şifreniz mail adresinize gönderilmiştir.";
                    }
                    catch (Exception ex )
                    {
                        string hata = ex.Message;
                    }
                }
                else
                {
                    lblmesaj.Text = "Bu mail adresi kayıtlı değildir";
                }
            }
        }

        private DataModel.Kullanicilar EmailKontrol(string email)
        {
                var User = (from k in ent.Kullanicilar
                         where k.kullaniciad == email && k.silindi == false
                         select k).FirstOrDefault();

            //if (User != null) return true;
            //return false;
            return User;
        }
    }
}
