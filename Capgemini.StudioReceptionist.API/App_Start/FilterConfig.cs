using System.Web;
using System.Web.Mvc;

namespace Capgemini.StudioReceptionist.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
