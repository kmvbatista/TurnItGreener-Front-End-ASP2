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

        public LoginController(IHttpClientFactory httpClientFactory, ICookie cookieManagement)
        {
            this.httpClient = httpClientFactory;
            this.cookieManagement = cookieManagement;

        }
        private readonly IHttpClientFactory httpClient;
        private readonly ICookie cookieManagement;



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

        public async Task<String> Login()
        {
            var value = new
            {
                email = "kennedy@gmail.com",
                password = "12345678"
            };
            var client = httpClient.CreateClient("turnItgreener");
            LoginTeste login = new LoginTeste()
            {
                Email = "kennedy@gmail.com",
                Password = "12345678"
            };
            HttpResponseMessage response = await client.PostAsJsonAsync<LoginTeste>("api/token", login);
            string json = response.Content.ReadAsStringAsync().Result;
            RootObject root = JsonConvert.DeserializeObject<RootObject>(json);
            User userReturned = root.user;

            //cookieManagement.Set("abc", "123");
            //User user = JsonDll.JsonConvert.DeserializeObject<User>(json);
            return cookieManagement.GetCookie();
                

            if(response != null)
            {
                return JsonConvert.SerializeObject(json);
            }
            return "Não encontrado";
        }

        public string retornaObjetoJSON()
        {
            //{“nome” : “Bill”, “idade” : 32, “salario”: 121232.67}

            var obj = new {email = "kennedy@gmail.com", password = "12345678"};

            return JsonConvert.SerializeObject(obj);
        }
    }
    public class LoginTeste
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }

}
