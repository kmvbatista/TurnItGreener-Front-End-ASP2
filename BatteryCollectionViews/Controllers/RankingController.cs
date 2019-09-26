using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BatteryCollectionViews.Cookies;
using BatteryCollectionViews.Models;
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

        //public ActionResult GetJsonData()
        //{
        //    var teste = new
        //    {
        //        Valor = 5
        //    };
        //    return Json(teste);
        //}

        //internal async Task<List<MyData_Simple>> LoadData_SimpleAsync()
        //{
        //    List<MyData_Simple> temp = new List<MyData_Simple>();

        //    Random r = new Random();
        //    DateTime now = DateTime.Today;

        //    await Task.Run(() =>
        //    {
        //        for (int i = 0; i < 7; i++)
        //        {
        //            temp.Add(new MyData_Simple()
        //            {
        //                COUNT = r.Next(1000)
        //            });

        //            now = now.AddDays(-1);
        //        }
        //    });

        //    return temp;
        //}

        //public async Task<ActionResult> OnGetRankingLine()
        //{
        //    RankingController data = new RankingController();
        //    List<MyData_Simple> temp = await data.LoadData_SimpleAsync();

        //    string[] labels = null;
        //    string[] COUNT = null;


        //    labels = (from x in temp
        //              select x.DAY).ToArray();

        //    COUNT = (from x in temp
        //             select x.COUNT.ToString()).ToArray();

        //    return new JsonResult(new
        //    {
        //        mylabels = labels,
        //        myCount = COUNT
        //    });
        //}

        public RankingController(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory;

        }
        private readonly IHttpClientFactory httpClient;

        public async Task<User> OnGetRankingLine()
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
                return userReturned;
            }
            return null;

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