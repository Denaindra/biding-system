using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTenderingSystem
{
    public partial class ViewTenderDetails : System.Web.UI.Page
    {
        private user tenderuser = new user();
        private tenderitems solditems = new tenderitems();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadtenderdetails();
        }

        public void loadtenderdetails()
        {
            itemlist.DataSource = tenderuser.gettenderuserdetails(Session["tenderuser"].ToString());
            itemlist.DataBind();
        }

        protected void stopdentering_Click(object sender, EventArgs e)
        {
            LinkButton linkbut = (LinkButton)sender;
            string userid = linkbut.CommandArgument;
            solditems.addtohistory(solditems.getitemnameselected(Int32.Parse(Session["searchitemid"].ToString())), Int32.Parse(Session["searchitemid"].ToString()), Session["tenderuser"].ToString());
            solditems.removeitem(Int32.Parse(Session["searchitemid"].ToString()));

            tenderuser = tenderuser.gettopseller(Session["tenderuser"].ToString());
            StringBuilder sb = new StringBuilder();
            string output ="email of "+tenderuser.Email+"  seller name is "+tenderuser.Username+" and username is"+tenderuser.Userid ;
            sb.Append(output);
            sb.Append("\r\n");
            string text = sb.ToString();
            Response.Clear();
            Response.ClearHeaders();
            Response.AddHeader("Content-Length", text.Length.ToString());
            Response.ContentType = "text/plain";
            Response.AppendHeader("content-disposition", "attachment;filename=\"sellerDetails.txt\"");
            Response.Write(text);
            Response.End();
            Response.Redirect("ViewTernderapplys.aspx");
        }
    }
}