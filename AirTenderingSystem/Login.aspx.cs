using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTenderingSystem
{
    public partial class Login : System.Web.UI.Page
    {
        private user userllogin = new user();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            if (userllogin.login(username.Text, password.Text))
            {
                Session["username"] = username.Text;
                if (userllogin.usertype(username.Text))
                {
                    if (username.Text == "abc" && password.Text == "abc")
                    {
                        Response.Redirect("EvaluvatorPanel.aspx");
                    }
                    else
                    {
                        Response.Redirect("adminpanel.aspx");
                    }
                }
                else {
                    Response.Redirect("index.aspx");
                }
             }
            else {
                Literal1.Text = "Your username and password incorrect";
            }
        }
    }
}