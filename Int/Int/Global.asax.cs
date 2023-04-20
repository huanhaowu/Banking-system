using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using log4net;

namespace Int
{
    public class Global : HttpApplication
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Environment.MachineName);

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            Logger.Info("Testing information log");
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }
    }
}