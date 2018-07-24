using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Portfolio_Site
{
    public class Global : System.Web.HttpApplication
    {   
        

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Users"] = 0;

            
            Data.WriteToLog("Application started.");
        }

        protected void Application_Init(object sender, EventArgs e)
        {
            Data.WriteToLog("Application initialized.");
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["Users"] = (int)Application["Users"] + 1;
            Data.WriteToLog("Session started. Current number of users: " + (int)Application["Users"] + ".");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication s = (System.Web.HttpApplication)sender;
            if (s.Request.RequestType == "POST")
            {
                


                if (s.Request.Params.AllKeys[4] == "btnAdd")
                {
                    Data.WriteToLog("User added two numbers together.");
                }
                else if (s.Request.Params.AllKeys[4] == "btnSubtract")
                {
                    Data.WriteToLog("User subtracted one number from another.");
                }
                else if (s.Request.Params.AllKeys[4] == "btnMultiply")
                {
                    Data.WriteToLog("User multiplied two numbers together.");
                }
                else if (s.Request.Params.AllKeys[4] == "btnDivide")
                {
                    Data.WriteToLog("User divided one number by another.");
                }
                
            }
            

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception except = Server.GetLastError();
            
            if(except.GetType() == typeof(HttpException))
            {
                if(except.Message.Contains("NoCatch") || except.Message.Contains("maxUrlLength"))
                {
                    return;
                }

                Server.Transfer("Default.aspx");
            }

            Response.Write("<h2>Global Page Error</h2>\n");
            Response.Write("<p>" + except.InnerException.Message + "</p>\n");
            Response.Write("Do you know what that means? It means you hecked up. Now return to the <a href='Default.aspx'>" + "Default Page</a>\n");

            Data.WriteToLog("Unhandled exception occurred. Exception Message: " + except.Message + ".");

            Server.ClearError();
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["Users"] = (int)Application["Users"] - 1;
            Data.WriteToLog("Session started. Current number of users: " + (int)Application["Users"] + ".");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Data.WriteToLog("Application closed.");
        }
    }
}