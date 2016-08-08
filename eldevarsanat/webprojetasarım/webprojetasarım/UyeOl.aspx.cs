using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace webprojetasarım
{
  
    public partial class UyeOl : System.Web.UI.Page
    {
        DataModel.SETEKwebprojeEntities ent = new DataModel.SETEKwebprojeEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtKullaniciAdi.Focus();
            }
        }

        protected void btnKayit_Click(object sender, EventArgs e)
        {
            if (cbxSozlesme.Checked == false)
            {
                lblMesaj.Text = "Gizlilik Sözleşmesini kabul etmelisiniz";
            }
            else
            {
                if (EmailKontrol(txtKullaniciAdi.Text))
                {
                    lblMesaj.Text = "Girdiğiniz Email daha önce kayıtlı";
                }
                else
                {
                    DataModel.Kullanicilar k = new DataModel.Kullanicilar();
                    k.KullaniciAdi = txtKullaniciAdi.Text;
                    k.Sifre = txtsifre.Text;
                    k.Ad = txtad.Text;
                    k.Soyad = txtsoyad.Text;
                    k.TCKNo = txtTCKNo.Text;
                    k.Telefon = txtTelefon.Text;
                    k.Adres = txtAdres.Text;
                    k.il = txtil.Text;
                    k.ilce = txtilce.Text;
                    ent.Kullanicilar.Add(k);
                    try
                    {
                        ent.SaveChanges();
                        lblMesaj.Text="Üyelik kaydınız başarıyla gerçekleştirilmiştir.";
                        Response.Redirect ("Anasayfa.aspx");
                    }
                    catch (SqlException ex)
                    {
                        string hata = ex.ToString();
                    }

                }
            }
        }
        public bool EmailKontrol(string email)
        {
            var kullanıcıemail=(from e in ent.Kullanicilar
                      where e.KullaniciAdi==email && e.Silindi==false
                      select e).FirstOrDefault();
            if (kullanıcıemail!=null) return true;
            return false;
        }
    }
}