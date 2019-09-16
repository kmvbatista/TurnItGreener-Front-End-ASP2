using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using BatteryCollectionViews.Cookies;

namespace BatteryCollectionViews.Controllers
{
    public class BaseController : Controller
    {
        private readonly ICookie cookie;
        public BaseController(ICookie _cookie)
        {
            this.cookie = _cookie;
        }

        public BaseController()
        {

        }
        //Antes de executar qualquer método do controller
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //if (string.IsNullOrWhiteSpace(cookie.GetCookie()))
            //{
            //    filterContext.Result = new RedirectResult(Url.Action("Index", "Login"));
            //}
            //base.OnActionExecuting(filterContext);
        }
    }
}