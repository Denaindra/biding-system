using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTenderingSystem
{
    public partial class ViewTernderapplys : System.Web.UI.Page
    {
        private Items ITEM = new Items();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Session["searchitemid"] = Int32.Parse(itemid.Text);
            if (itemid.Text!="") {
                itemlist.DataSource = ITEM.getlowestDiliverytime(Int32.Parse(itemid.Text));
                itemlist.DataBind();
                Literal10.Text = "Most appropriate Seller";
                loadrejecteditemsellers();
            } else {
                erromessage.Text = "item id required";
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Session["searchitemid"] = Int32.Parse(itemid.Text);
            if (itemid.Text != "")
            {
                ITEM.getbestSeller(Int32.Parse(itemid.Text));
                itemlist.DataSource = ITEM.getbesttender();
                itemlist.DataBind();
                Literal10.Text = "Most appropriate Seller";
                loadrejecteditemsellers();
            }
            else {
                erromessage.Text = "item id required";
            }
        }
        public void loadrejecteditemsellers() {
            Literal8.Text = "Availabel Sellers";
            rejected.DataSource = ITEM.getrejectedsellers(Int32.Parse(itemid.Text));
            rejected.DataBind();

            Literal9.Text = "Not Eligibel Sellers";
            noteligibel.DataSource = ITEM.getnoteligibelset(Int32.Parse(itemid.Text));
            noteligibel.DataBind();
        }
     
        protected void loaditems_Click(object sender, EventArgs e)
        {
           
            LinkButton linkbut = (LinkButton)sender;
            string username = linkbut.CommandArgument;
            Session["tenderuser"] = username;
            Response.Redirect("ViewTenderDetails.aspx");
        }

    }
}