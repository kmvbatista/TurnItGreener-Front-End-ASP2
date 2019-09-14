using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatteryCollectionViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace BatteryCollectionViews.Controllers
{
    public class LoginController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            return View();
        }
    }
}