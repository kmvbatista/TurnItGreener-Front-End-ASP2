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
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<User> Create(UserViewModel userViewModel)
        {
            var client = httpClient.CreateClient("turnItgreener");

            HttpResponseMessage response = await client.PostAsJsonAsync<User>("api/users", mapUser(userViewModel));
            string json = response.Content.ReadAsStringAsync().Result;
            RootObject root = JsonConvert.DeserializeObject<RootObject>(json);
            User userReturned = root.user;

            return userReturned;
        }

        private User mapUser(UserViewModel userViewModel)
        {
            return new User { name = userViewModel.Name, email = userViewModel.Email, password = userViewModel.Password };
        }

        public UserController(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory;
        }
        private readonly IHttpClientFactory httpClient;
    }
}