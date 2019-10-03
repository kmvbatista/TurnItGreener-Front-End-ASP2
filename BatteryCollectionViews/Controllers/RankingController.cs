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

        public async Task<Object> OnGetRankingTable()
        {
            var client = httpClient.CreateClient("turnItgreener");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Cookie.GetCookie(this.HttpContext));

            HttpResponseMessage response = await client.GetAsync("api/users/ranking");
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                RootArray root = JsonConvert.DeserializeObject<RootArray>(json);
                var userReturned = root.alldiscards.weekPoints;
                return userReturned;
            }
            return null;
        }
    }
}