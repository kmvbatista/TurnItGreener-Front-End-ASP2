using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BatteryCollectionViews.Models;
using BatteryCollectionViews.Models.HttpResponse;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BatteryCollectionViews.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string a1, int a2 = 0)
        {
            return View();
        }

        public AccountController(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory;

        }
        private readonly IHttpClientFactory httpClient;

        public async Task<Object> OnGetRankingBar()
        {
            var client = httpClient.CreateClient("turnItgreener");
            UserSend userSend = new UserSend()
            {
                Id = 3
            };
            HttpResponseMessage response = await client.PostAsJsonAsync<UserSend>("api/Users", userSend);
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                RootArray root = JsonConvert.DeserializeObject<RootArray>(json);
                var userReturned = root.alldiscards.yearPoints;
                return userReturned;
            }
            return null;
        }
    }
}