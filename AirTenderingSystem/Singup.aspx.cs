using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTenderingSystem
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private user newuser = new user();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (password.Text == repassword.Text)
            {
                newuser.sellerRegistration(username.Text, password.Text, email.Text);
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}