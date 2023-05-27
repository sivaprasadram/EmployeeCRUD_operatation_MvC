using System.Web;
using System.Web.Mvc;

namespace EmployeeCRUD_operatation_MvC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
