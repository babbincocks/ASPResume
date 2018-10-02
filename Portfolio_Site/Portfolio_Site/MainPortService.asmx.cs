using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;

namespace Portfolio_Site
{
    /// <summary>
    /// Summary description for MainPortService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MainPortService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<string> NumberConversion(decimal number)
        {
            List<string> convertedNum = new List<string>();
            decimal numBase = 2m;
            for (int a = 0; a < 3; a++)
            {

                int remainder = (int)(number % numBase);
                decimal cutNumber = (int)(number / numBase);
                List<char> newNumber = new List<char>();
                
                while((int)cutNumber != 1)
                {
                    
                    newNumber.Add((char)remainder);
                    remainder = (int)(cutNumber % numBase);
                    cutNumber = (int)(cutNumber / numBase);
                }

                newNumber.Reverse();

                if(a == 0)
                {
                    numBase = 8m;
                    //TODO: This method of adding the number isn't working. Also when adding digits in binary up above, it misses one digit; what should be the first digit.
                    convertedNum.Add(string.Concat(newNumber.TakeWhile(char.IsDigit)));
                    newNumber.Clear();
                }
                else
                {
                    numBase = 16m;
                    convertedNum.Add(string.Concat(newNumber.TakeWhile(char.IsLetterOrDigit)));
                    newNumber.Clear();
                }
            }
            return convertedNum;
        }
    }
}
