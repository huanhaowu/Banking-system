using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Core
{
    /// <summary>
    /// Summary description for wsCore
    /// </summary>
    [WebService(Namespace = "http://intec.edu.do/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCore : System.Web.Services.WebService
    {
        [WebMethod]
        public string Prueba(string name)
        {
            return "Esto es una prueba para " + name;
        }
    }
}
