using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Core
{

    // CONNECTION STRING 
    //conn = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\msi\OneDrive - INTEC\INTEC\Trimestre 7\Desarrollo de software III\Proyecto Final\Proyecto-Banco\Proyecto-Banco\Core\App_Data\DbCore.mdf;Integrated Security=True"

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
