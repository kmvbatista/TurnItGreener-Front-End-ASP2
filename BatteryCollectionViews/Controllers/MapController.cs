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
    public class MapController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string a1, int a2 = 0)
        {
            string id = Cookie.GetCookie(this.HttpContext);

            return View();
        }

        public MapController(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory;

        }
        private readonly IHttpClientFactory httpClient;

        public async Task<List<RootMap>> GetJsonMap()
        {
            var client = httpClient.CreateClient("turnItgreener");

            HttpResponseMessage response = await client.GetAsync("api/places");
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                List<RootMap> rootMap = JsonConvert.DeserializeObject<List<RootMap>>(json);
                return rootMap;
            }
            return null;
        }
    }
}