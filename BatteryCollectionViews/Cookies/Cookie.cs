using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace BatteryCollectionViews.Cookies
{
    public class Cookie
    {
        private const string CookieSetting = "Cookie.Duration";
        private const string CookieIsHttp = "Cookie.IsHttp";
        public const string CookieName = "MVCAPP";

        public static void Set(string value, HttpContext context)
        {
            var options = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(30),
                HttpOnly = true,
            };
            context.Response.Cookies.Append(CookieName, value, options);
        }

        internal static string GetCookie(HttpContext context)
        {
            return context.Request.Cookies[CookieName];
        }

        public static void Delete(string key, HttpContext context)
        {
            context.Response.Cookies.Delete(key);
        }

        public static void DeleteAll()
        {
            throw new NotImplementedException();
        }
    }
}
