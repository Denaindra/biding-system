using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTenderingSystem
{
    public partial class History : System.Web.UI.Page
    {
        private tenderhistory histry = new tenderhistory();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadhistory();
        }

        private void loadhistory()
        {
            if (Session["username"] == null)
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                history.DataSource = histry.gethistory(Session["username"].ToString());
                history.DataBind();
            }
        }
    }
}