using System.Web;
using System.Web.Mvc;

namespace WebAppFromWebHost_Consumer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
