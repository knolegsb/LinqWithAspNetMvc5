using System.Web;
using System.Web.Mvc;

namespace LinqWithAsp.NetMvc5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
