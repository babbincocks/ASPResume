using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio_Site
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Length > 0 && txtPass.Text == txtPassConf.Text)
            {
                if (Data.CheckLogin(txtUser.Text, txtPass.Text) == -1)
                {
                    try
                    {
                        Data.RegisterUser(txtUser.Text, txtPass.Text);
                        txtUser.Text = "";
                        txtPass.Text = "";
                        Response.Redirect("Login.aspx");
                        
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                }
                else if (txtUser.Text.Length > 0)
                {
                    Response.Write("That username is already taken.");
                }
            }
            else
            {
                Response.Write("Please enter two matching, valid passwords.");
            }
            

        }
    }
}