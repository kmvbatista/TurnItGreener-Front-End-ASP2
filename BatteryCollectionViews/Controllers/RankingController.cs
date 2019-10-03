using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

        public RankingController(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory;

        }
        private readonly IHttpClientFactory httpClient;

        public async Task<List<RootJson>> OnGetRankingTable()
        {
            var client = httpClient.CreateClient("turnItgreener");
            var cookie = Cookie.GetCookie(this.HttpContext);
            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(cookie);

            HttpResponseMessage response = await client.GetAsync("api/users/ranking");
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;

                List<RootJson> rootJson = JsonConvert.DeserializeObject<List<RootJson>>(json);
                return rootJson;
            }
            return null;
        }
    }
}