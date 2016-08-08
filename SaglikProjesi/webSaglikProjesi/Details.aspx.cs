﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class Details : System.Web.UI.Page
    {
        DataModel.SaglikUrunleriEntities ent = new DataModel.SaglikUrunleriEntities();
        Models.cSepet spt = new Models.cSepet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["urunid"]);
                Urunlerigetir(id);

                if (Session["sepet"] != null)
                {
                    DataTable dt = (DataTable)Session["sepet"];
                    GridView sepetozet = (GridView)this.Master.FindControl("gvsepetozet");
                    sepetozet.Columns[0].FooterText = "Toplam : ";
                    sepetozet.Columns[1].FooterText = string.Format("{0:C}", ToplamTutarBul());
                    sepetozet.DataSource = dt;
                    sepetozet.DataBind();
                }
            }
        }

        private void Urunlerigetir(int id)
        {
            var urun = (from u in ent.Urunler
                        where u.urunid == id
                        select u).ToList();
            dlstUrunler.DataSource = urun;
            dlstUrunler.DataBind();

           
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
        protected void dlstUrunler_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "sepet")
            {
                if (Session["sepet"] == null)
                {
                    Session["sepet"] = spt.YeniSepet();
                }
                DataTable dt = (DataTable)Session["sepet"];
                int id = Convert.ToInt32(e.CommandArgument);
                Label UrunAdi = (Label)e.Item.FindControl("lblurunad");
                Label Fiyat = (Label)e.Item.FindControl("lblurunfiyat");
                TextBox Adet = (TextBox)e.Item.FindControl("txtadet");
                Label UrunBilgi = (Label)e.Item.FindControl("lblurunbilgi");
                bool varmi = false; // urun varmi yok mu kontrol icin

                foreach (DataRow urun in dt.Rows)
                {
                    if (Convert.ToInt32(urun["urunID"]) == id)
                    {
                        varmi = true;
                        urun["adet"] = Convert.ToInt32(urun["adet"]) + Convert.ToInt32(Adet.Text);
                        urun["tutar"] = Convert.ToDecimal(urun["tutar"]) + (Convert.ToInt32(Adet.Text) * Convert.ToDecimal(Fiyat.Text));
                        break;
                    }
                }

                if (varmi == false)
                {
                    DataRow dr;
                    dr = dt.NewRow();
                    dr["urunID"] = id;
                    dr["urunad"] = UrunAdi.Text;
                    dr["adet"] = Convert.ToInt32(Adet.Text);
                    dr["fiyat"] = Convert.ToDecimal(Fiyat.Text);
                    dr["tutar"] = Convert.ToInt32(Adet.Text) * Convert.ToDecimal(Fiyat.Text);

                    dt.Rows.Add(dr);
                 
                 
                }
                Session["Sepet"] = dt;
                 Response.Redirect("sepet.aspx");
                //Response.Redirect("default.aspx");
            }
        }
        }
}