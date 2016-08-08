using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        DataModel.SaglikUrunleriEntities ent = new DataModel.SaglikUrunleriEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var categories = (from category in ent.Kategoriler
                                  where category.silindi == false
                                  select category).ToList();

                foreach (var kategori in categories)
                {
                    MenuItem m = new MenuItem();
                    m.Text = kategori.kategoriad;
                    m.Value = kategori.id.ToString();
                    mnuKategoriler.Items.Add(m);

                    var subcategories = (from alt in ent.AltKategoriler
                                         where alt.silindi == false && alt.kategorino == kategori.id
                                         select alt).ToList();

                    foreach (var altkategori in subcategories)
                    {
                        MenuItem citem = new MenuItem();
                        citem.Text = altkategori.altkategoriad;
                        citem.Value = altkategori.id.ToString();
                        m.ChildItems.Add(citem);
                    }
                }
            }
        }




        protected void mnuKategoriler_MenuItemClick(object sender, MenuEventArgs e)
        {

            //Response.Write("Kategori : " + e.Item.Text + ", ID : " + e.Item.Value);
            Response.Write(e.Item.ValuePath);
            string[] Degerler = e.Item.ValuePath.Split('/');
            int altkno = 0;
            if (Degerler.Length > 1)
            {
                altkno = Convert.ToInt32(Degerler[1]);
            }
            Response.Redirect("Products.aspx?kno=" + Degerler[0] + "&akno=" + altkno);//Response.Write("Kategori : " + e.Item.Text + 
        }
    }
}