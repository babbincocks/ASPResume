﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio_Site
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                btnLogin.Visible = (Session["LoginState"] == null);

                if (Session["LoginState"] != null)
                {
                    lblUser.Visible = true;
                    lblUser.Text = "Welcome, " + Session["LoginState"] + ".";
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session["PrevPage"] = Page.Application;
            Response.Redirect("Login.aspx");
        }
    }
}