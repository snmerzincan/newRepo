using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webprojetasarım
{
    public partial class UrunDetayi : System.Web.UI.Page
    {
        DataModel.SETEKwebprojeEntities ent = new DataModel.SETEKwebprojeEntities();
        Models.SepetIslem sepet = new Models.SepetIslem();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["UrunID"]);
                UrunleriGetir(id);

                //if (Session["sepet"] != null)
                //{
                //    DataTable dt = (DataTable)Session["sepet"];
                //    GridView sepetozet = (GridView)this.Master.FindControl("gvsepetozet");
                //    sepetozet.Columns[0].FooterText = "Toplam : ";
                //    sepetozet.Columns[1].FooterText = string.Format("{0:C}", ToplamTutarBul());
                //    sepetozet.DataSource = dt;
                //    sepetozet.DataBind();
                //}
            }
        }

        private void UrunleriGetir(int id)
        {
            var urun = (from u in ent.Urunler
                        where u.UrunID == id
                        select u).ToList();
            dtUrunDetay.DataSource = urun;
            dtUrunDetay.DataBind();
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

        protected void dtUrunDetay_ItemCommand1(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "SepeteEkle")
            {
                if (Session["sepet"] == null)
                {
                    Session["sepet"] = sepet.YeniSepet();
                }
                DataTable dt = (DataTable)Session["sepet"];
                int id = Convert.ToInt32(e.CommandArgument);
                Label UrunAdi = (Label)e.Item.FindControl("lblurunad");
                Label Fiyat = (Label)e.Item.FindControl("lblurunfiyat");
                TextBox Adet = (TextBox)e.Item.FindControl("txtadet");
                Label UrunBilgi = (Label)e.Item.FindControl("lblurunbilgi");
                bool varmi = false;

                foreach (DataRow urun in dt.Rows)
                {
                    if (Convert.ToInt32(urun["UrunID"]) == id)
                    {
                        varmi = true;
                        urun["Adet"] = Convert.ToInt32(urun["Adet"]) + Convert.ToInt32(Adet.Text);
                        urun["Tutar"] = Convert.ToDecimal(urun["Tutar"]) + (Convert.ToInt32(Adet.Text) * Convert.ToDecimal(Fiyat.Text));
                        break;
                    }
                }

                if (varmi == false)
                {
                    DataRow dr;
                    dr = dt.NewRow();
                    dr["UrunID"] = id;
                    dr["UrunAd"] = UrunAdi.Text;
                    dr["Adet"] = Convert.ToInt32(Adet.Text);
                    dr["Fiyat"] = Convert.ToDecimal(Fiyat.Text);
                    dr["Tutar"] = Convert.ToInt32(Adet.Text) * Convert.ToDecimal(Fiyat.Text);

                    dt.Rows.Add(dr);


                }
                Session["Sepet"] = dt;
                Response.Redirect("Sepet.aspx");
            }
        }
    }
}