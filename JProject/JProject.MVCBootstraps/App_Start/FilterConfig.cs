using System.Web;
using System.Web.Mvc;

namespace JProject.MVCBootstraps
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
