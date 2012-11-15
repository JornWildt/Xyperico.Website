using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using log4net;
using Xyperico.Web.Mvc;


namespace Xyperico.Website.Core
{
  public class Global : Xyperico.Web.Mvc.Global
  {
    static ILog Logger = LogManager.GetLogger(typeof(Global));


    override protected void Application_Start()
    {
      base.Application_Start();

      WebApiConfig.Register(GlobalConfiguration.Configuration);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);

      Themes.SetupThemes();
    }
  }
}
