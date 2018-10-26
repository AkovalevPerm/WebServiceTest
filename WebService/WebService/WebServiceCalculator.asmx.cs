using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for WebServiceCalculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCalculator : System.Web.Services.WebService
    {

        [WebMethod]
        public double Sum(double x, double y)
        {
            return x+y;
        }

        [WebMethod]
        public double Sub(double x, double y)
        {
            return x - y;
        }

        [WebMethod]
        public double Div(double x, double y)
        {
            return x / y;
        }

        [WebMethod]
        public double Mult(double x, double y)
        {
            return x * y;
        }
    }
}
