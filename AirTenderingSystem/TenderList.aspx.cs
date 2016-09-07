using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTenderingSystem
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        private Database databse = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {
            viewtenderitems();
        }

        public void viewtenderitems()
        {
            itemlist.DataSource = databse.AvailablegetItemlists();
            itemlist.DataBind();
        }

        protected void getItemID_Click(object sender, EventArgs e)
        {
            LinkButton linkbut = (LinkButton)sender;
            string ID = linkbut.CommandArgument;
            Session["ItemID"] = linkbut.CommandArgument;
           
            Response.Redirect("criteria selection.aspx");
            
        }
    }
}