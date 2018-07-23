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
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int result = -1;
            
            
        }
    }
}