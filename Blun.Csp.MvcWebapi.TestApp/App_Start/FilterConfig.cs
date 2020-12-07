using System.Web;
using System.Web.Mvc;

namespace Blun.Csp.MvcWebapi.TestApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
