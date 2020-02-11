using System.Web;
using System.Web.Mvc;

namespace SophiyaGitDevOpsApp11Feb020
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
