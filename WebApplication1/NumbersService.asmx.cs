using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for NumbersService
    /// </summary>
    [WebService(Namespace = "http://demo.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NumbersService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        /// <summary>
        /// This method adds two numbers
        /// </summary>
        /// <param name="x">First param</param>
        /// <param name="y">Second param</param>
        /// <returns></returns>
        [WebMethod]
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
