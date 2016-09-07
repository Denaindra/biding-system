using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTenderingSystem
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        private Items additem = new Items();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            additem.addItems(itemname.Text, DateTime.Parse(opeingdate.Text),DateTime.Parse(Endingdate.Text), deisrption.Text, dropbox.Text,true,Int32.Parse(quntity.Text));
        }
    }
}