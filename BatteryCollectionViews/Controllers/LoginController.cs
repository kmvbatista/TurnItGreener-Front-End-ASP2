using System;
using System.Threading.Tasks;
using BatteryCollectionViews.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using BatteryCollectionViews.Cookies;
using JsonDll = Newtonsoft.Json;
using BatteryCollectionViews.Models.HttpResponse;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;

namespace BatteryCollectionViews.Controllers
{
    public class LoginController : Controller
    {
        public Cookie cookie = new Cookie();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var client = httpClient.CreateClient("turnItgreener");
          
            User user = new User()
            {
                email = model.Email,
                password = model.Password
            };

            HttpResponseMessage response = await client.PostAsJsonAsync<User>("api/token", user);
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;

                RootObject root = JsonConvert.DeserializeObject<RootObject>(json);
                Cookie.Set(json, this.HttpContext);
                return RedirectToAction("Index", "PrincipalHome");
            }
            else
            {
                ViewBag.Errors = "Usuário e/ou senha inválidos.";
            }
            return View();
        }

        public LoginController(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory;

        }
        private readonly IHttpClientFactory httpClient;
    }
}
