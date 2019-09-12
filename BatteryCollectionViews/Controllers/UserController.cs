using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatteryCollectionViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace BatteryCollectionViews.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserViewModel model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(UserViewModel model)
        {
            return View();
        }
    }
}