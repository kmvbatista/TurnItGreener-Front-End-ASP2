using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BatteryCollectionViews.Cookies;
using BatteryCollectionViews.Models.HttpResponse;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BatteryCollectionViews.Controllers
{
    public class RankingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetJsonData()
        {
            var teste = new
            {
                Nome = "Teste",
                Valor = 5
            };
            return Json(teste);
        }

        public RankingController(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory;

        }
        private readonly IHttpClientFactory httpClient;

        public async Task<IActionResult> RankingBar()
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
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                RootObject root = JsonConvert.DeserializeObject<RootObject>(json);
                User userReturned = root.user;
                //Cookie.Set(userReturned.email + " " + userReturned.name, HttpContext);
                //Cookie.GetCookie(HttpContext);
                return View();
            }

            return View();

            //cookieManagement.Set("abc", "123");
            //User user = JsonDll.JsonConvert.DeserializeObject<User>(json);


            //if(response != null)
            //{
            //    return JsonConvert.SerializeObject(json);
            //}
            //return "Não encontrado";
        }
    }
}