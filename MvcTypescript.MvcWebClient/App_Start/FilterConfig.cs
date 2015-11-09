using System.Web;
using System.Web.Mvc;

namespace MvcTypescript.MvcWebClient
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
