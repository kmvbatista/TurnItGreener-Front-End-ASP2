using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BatteryCollectionViews.Controllers
{
    public class ProfileController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string a1, int a2 = 0)
        {
            //CustomModelBinder
            //string valçor = Request.Form["a1"];
            return View();
        }
        //<form>
        //<input type='text' name='a1' />
        //</form>
    }
}