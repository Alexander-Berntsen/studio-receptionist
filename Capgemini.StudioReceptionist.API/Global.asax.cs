using System;
using System.Diagnostics;
using System.IO;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Capgemini.StudioReceptionist.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private static Process process;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

#if DEBUG
            Directory.SetCurrentDirectory(Server.MapPath("~"));
            process = Process.Start("CMD.exe", "/Kcd ..\\Capgemini.StudioReceptionist.UI && npm start");
            Process.Start("cmd", "/C start http://localhost:8080");
#endif
        }

        protected void Application_End()
        {
#if DEBUG
            process.Kill();
#endif
        }


    }
}
