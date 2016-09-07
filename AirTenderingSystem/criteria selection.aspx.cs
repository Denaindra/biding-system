using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTenderingSystem
{
    public partial class criteria_selection : System.Web.UI.Page
    {
        private user userlist = new user();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                username.DataSource = userlist.getuserist();
                username.DataValueField = "username";
                username.DataTextField = "username";
                username.DataBind();
            }
        }

        private void deselectRedioBtn()
        {
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            RadioButton5.Checked = false;
            RadioButton6.Checked = false;
            RadioButton7.Checked = false;
            RadioButton8.Checked = false;
            RadioButton9.Checked = false;
            RadioButton10.Checked = false;
            RadioButton11.Checked = false;
            RadioButton12.Checked = false;
            RadioButton13.Checked = false;
            RadioButton14.Checked = false;
            RadioButton15.Checked = false;
            RadioButton16.Checked = false;
            RadioButton17.Checked = false;
            RadioButton18.Checked = false;
            RadioButton19.Checked = false;
            RadioButton20.Checked = false;
            RadioButton21.Checked = false;
            RadioButton22.Checked = false;
            RadioButton23.Checked = false;
            RadioButton24.Checked = false;
            RadioButton25.Checked = false;
            RadioButton26.Checked = false;
            RadioButton27.Checked = false;
            RadioButton28.Checked = false;
            RadioButton29.Checked = false;
            RadioButton30.Checked = false;
            RadioButton31.Checked = false;
            RadioButton32.Checked = false;
            RadioButton33.Checked = false;
            RadioButton34.Checked = false;
            RadioButton35.Checked = false;
            RadioButton36.Checked = false;
            RadioButton37.Checked = false;
            RadioButton38.Checked = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["sellerUsername"] = username.Text;
            if (RadioButton1.Checked && RadioButton3.Checked && RadioButton5.Checked && RadioButton7.Checked && RadioButton9.Checked && RadioButton11.Checked && RadioButton13.Checked
                && RadioButton15.Checked && RadioButton17.Checked && RadioButton19.Checked && RadioButton21.Checked && RadioButton23.Checked && RadioButton25.Checked
                && RadioButton27.Checked && RadioButton29.Checked && RadioButton31.Checked && RadioButton33.Checked && RadioButton35.Checked
                && RadioButton37.Checked)
            {
                Response.Redirect("TenderDetails.aspx");
            }
            else
            {
                Response.Redirect("Noteligiblesupler.aspx");
            }
        }
    }
}