using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatteryCollectionViews.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace BatteryCollectionViews.Controllers
{
    public class MapController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string a1, int a2 = 0)
        {
            string id = Cookie.GetCookie(this.HttpContext);

            return View();
        }
    }
}