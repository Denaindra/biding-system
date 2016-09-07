using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTenderingSystem
{
    public partial class Noteligiblesupler : System.Web.UI.Page
    {
        private tenderitems tender = new tenderitems();
        private user getuserlist = new user();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            
            getuserlist.addNoteligibelsellers(Session["sellerUsername"].ToString(), Int32.Parse(Session["ItemID"].ToString()),Int32.Parse(warantee.Text),double.Parse(price.Text),double.Parse(freight.Text),Int32.Parse(deliverydate.Text));
            message.Text = "Sucessfull";
            warantee.Text = "";
            price.Text = "";
            Response.Redirect("criteria selection.aspx");
        }

        protected void evaluvate_Click(object sender, EventArgs e)
        {
            getuserlist.addNoteligibelsellers(Session["sellerUsername"].ToString(), Int32.Parse(Session["ItemID"].ToString()), Int32.Parse(warantee.Text), double.Parse(price.Text), double.Parse(freight.Text), Int32.Parse(deliverydate.Text));
            message.Text = "Sucessfull";
            warantee.Text = "";
            price.Text = "";
            Response.Redirect("ViewTernderapplys.aspx");
        }
    }
}