using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTenderingSystem
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private tenderitems tenders = new tenderitems();
        private user getuserlist = new user();
        protected void Page_Load(object sender, EventArgs e)
        {
     
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            tenders.applyDenter(Session["sellerUsername"].ToString(), Int32.Parse(Session["ItemID"].ToString()),Int32.Parse(waranty.Text) ,Double.Parse(price.Text),Int32.Parse(date.Text),Double.Parse(FreightCost.Text));
            tenders.eligibleapplyDenter(Session["sellerUsername"].ToString(), Int32.Parse(Session["ItemID"].ToString()), Int32.Parse(waranty.Text), Double.Parse(price.Text));
            message.Text = "Sucessfull";
            waranty.Text = "";
            price.Text = "";
            date.Text = "";
            FreightCost.Text = "";
            Response.Redirect("criteria selection.aspx");
        }

        protected void evaluvate_Click(object sender, EventArgs e)
        {
            tenders.applyDenter(Session["sellerUsername"].ToString(), Int32.Parse(Session["ItemID"].ToString()), Int32.Parse(waranty.Text), Double.Parse(price.Text), Int32.Parse(date.Text), Double.Parse(FreightCost.Text));
            tenders.eligibleapplyDenter(Session["sellerUsername"].ToString(), Int32.Parse(Session["ItemID"].ToString()), Int32.Parse(waranty.Text), Double.Parse(price.Text));
            message.Text = "Sucessfull";
            waranty.Text = "";
            price.Text = "";
            date.Text = "";
            FreightCost.Text = "";
            Response.Redirect("ViewTernderapplys.aspx");
        }
    }
}