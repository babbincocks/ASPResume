using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Portfolio_Site
{
    public class Data
    {
        public static void WriteToLog(string message)
        {
            if(!File.Exists(HttpRuntime.AppDomainAppPath + "\\Resources\\AppLog.txt"))
            {
                File.Create(HttpRuntime.AppDomainAppPath + "\\Resources\\AppLog.txt");
            }
            StreamWriter output = new StreamWriter(HttpRuntime.AppDomainAppPath + "\\Resources\\AppLog.txt", true);
            output.WriteLine(DateTime.Now.ToString() + ": " + message);
            output.Close();
        }

        public static int CheckLogin(string name, string pass)
        {
            int result = 0;

            //TODO: Connection string.
            string connString = WebConfigurationManager.ConnectionStrings["Laptop"].ConnectionString;



            return result;
        }
    }
}