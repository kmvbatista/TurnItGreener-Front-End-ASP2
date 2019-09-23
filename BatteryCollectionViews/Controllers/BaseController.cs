using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using BatteryCollectionViews.Cookies;

namespace BatteryCollectionViews.Controllers
{
    public class BaseController : Controller
    {
        //Antes de executar qualquer método do controller
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (string.IsNullOrWhiteSpace(Cookie.GetCookie(filterContext.HttpContext)))
            {
                filterContext.Result = new RedirectResult(Url.Action("Index", "Login"));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}