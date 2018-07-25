using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio_Site
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!Page.IsPostBack)
            {
                ViewState["LoggedIn"] = 0;
            }

            if (ViewState["LoggedIn"].ToString() == "1")
            {

                btnLogin.Enabled = false;
                Response.Write("There is no need to log yourself in again.");
            }
            if (Request.UrlReferrer.ToString() != null)
            {
                if (Request.UrlReferrer.LocalPath.Contains("Register"))
                {
                    Response.Write("New user created. Now login with your new credentials.");
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int result = -1;
            
            if(ViewState["LoggedIn"].ToString() != "1")
            {
                result = Data.CheckLogin(txtUser.Text, txtPass.Text);

                if(result == 1)
                {
                    ViewState["LoggedIn"] = result;
                    Session["LoginState"] = txtUser.Text;
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    Response.Write("Login information was incorrect. Please try again.");
                }
            }
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if(ViewState["LoggedIn"].ToString() != "1")
            {
                Response.Redirect("Register.aspx");
            }
            else
            {
                Response.Write("Logout before registering a new user.");
            }
            
        }
    }
}