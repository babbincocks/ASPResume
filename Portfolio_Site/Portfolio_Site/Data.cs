using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Security.Cryptography;
using System.Text;

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

            string connString = WebConfigurationManager.ConnectionStrings["Desktop Door"].ConnectionString;

            string encrypt = Encrypt(pass);

            using (SqlConnection sqlConn = new SqlConnection(connString))
            {

                SqlDataAdapter sqlAdapt = new SqlDataAdapter("dbo.sp_AllUsers", sqlConn);

                DataTable dtUsers = new DataTable();

                sqlAdapt.Fill(dtUsers);

                DataRow[] match = dtUsers.Select("Username = '" + name + "'");

                if (match.Length != 0)
                {
                    if (match[0].ItemArray[1].ToString() == encrypt)
                    {
                        result = 1;
                    }

                }
                else
                {
                    result = -1;
                }
            }

            return result;
        }


        private static string Encrypt(string check)
        {
            string encrypted = "";
            using (MD5 encryption = MD5.Create())
            {
                byte[] hash = encryption.ComputeHash(Encoding.UTF8.GetBytes(check));
                
                for(int i = 0;i<hash.Length;i++)
                {
                    encrypted += hash[i].ToString("X2");
                }
            }

                return encrypted;
        }

        public static void RegisterUser(string name, string pass)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Desktop Door"].ConnectionString;

            string encrypt = Encrypt(pass);

            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                string insertQuery = "INSERT INTO Users (Username, Pass) VALUES (@UsersName, @Passwordchoice)";

                SqlCommand insertComm = new SqlCommand(insertQuery, sqlConn);
                insertComm.Parameters.AddWithValue("@UsersName", name);
                insertComm.Parameters.AddWithValue("@Passwordchoice", encrypt);
                insertComm.Connection.Open();

                insertComm.ExecuteNonQuery();
            }


        }
    }
}