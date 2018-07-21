using System;
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
            btnLogin.Visible = (Session["LoginState"] == null);

            if(Session["LoginState"] != null)
            {
                lblUser.Visible = true;
                //TODO: Working here, put in text for lblUser.
                lblUser.Text = "";
            }
        }
    }
}