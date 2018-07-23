using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

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




            return result;
        }
    }
}