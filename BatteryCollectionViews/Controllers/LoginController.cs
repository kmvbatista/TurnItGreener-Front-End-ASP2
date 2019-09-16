using System;
using System.Threading.Tasks;
using BatteryCollectionViews.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

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

        public LoginController(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory;
        }
        private readonly IHttpClientFactory httpClient;


        public async Task OnGet()
        {
            var value = "email: 'kennedy@gmail.com', password: '12345678'";
            var client = httpClient.CreateClient();
            var response = await client.PostAsJsonAsync("/api/controller", value);
        }

        private async Task<IActionResult> Post()
        {
            var value = "email: 'kennedy@gmail.com', password: '12345678'";
            var client = httpClient.CreateClient();

            var response = await client.PostAsJsonAsync("turnItgreener/api/controller", value);
            if (response != null)
            {
                return Json(response);
            }
            return BadRequest();
        }

        public async Task<IActionResult> Login()
        {
            var value = new
            {
                email = "kennedy@gmail.com",
                password = "12345678"
            };
            var client = httpClient.CreateClient("turnItgreener");
            var response = await client.PostAsJsonAsync("api/token", new StringContent(retornaObjetoJSON(), Encoding.UTF8, "application/json"));
            Console.WriteLine(retornaObjetoJSON().ToString());
            if (response != null)
            {
                return Json(response);
            }
            return BadRequest();
        }

        public string retornaObjetoJSON()
        {
            //{“nome” : “Bill”, “idade” : 32, “salario”: 121232.67}

            var obj = new {email = "kennedy@gmail.com", password = "12345678"};

            return JsonConvert.SerializeObject(obj);
        }
    }
}
