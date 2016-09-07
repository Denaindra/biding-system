using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTenderingSystem
{
    public partial class AdvertiseTenders : System.Web.UI.Page
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
    }
}