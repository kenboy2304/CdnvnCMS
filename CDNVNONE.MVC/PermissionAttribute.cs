using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace CDNVNONE.MVC
{
    public class PermissionAttribute : ActionFilterAttribute, IActionFilter
    {
        public string Name { get; set; }

        public PermissionAttribute()
        {
            
        }
        public PermissionAttribute(string name)
        {
            
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "Error" }));
            filterContext.Result.ExecuteResult(filterContext.Controller.ControllerContext);
            base.OnActionExecuting(filterContext);
        }
    }
}
