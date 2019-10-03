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
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace BatteryCollectionViews.Controllers
{
    public class ProfileController : BaseController
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string a1, int a2 = 0)
        {
            return View();
        }

        public ProfileController(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory;

        }
        private readonly IHttpClientFactory httpClient;

        public async Task<Object> OnGetRankingLine()
        {
            var client = httpClient.CreateClient("turnItgreener");
            var cookie = Cookie.GetCookie(this.HttpContext);
            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(cookie);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", rootObject.token.value.token);
            UserSend userSend = new UserSend()
            {
                Id = rootObject.userToSend.id

            };
            HttpResponseMessage response = await client.PostAsJsonAsync<UserSend>("api/discards/all", userSend);
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                RootArray root = JsonConvert.DeserializeObject<RootArray>(json);
                var userReturned = root;
                return userReturned;
            }
            return null;
        }
    }
}