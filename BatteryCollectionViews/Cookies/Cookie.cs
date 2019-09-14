using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace BatteryCollectionViews.Cookies
{
    public class Cookie : ICookie
    {
        private const string CookieSetting = "Cookie.Duration";
        private const string CookieIsHttp = "Cookie.IsHttp";
        public const string CookieName = "MVCAPP";
        private readonly IHttpContextAccessor _context;

        public Cookie(IHttpContextAccessor httpContextAccessor)
        {
            _context = httpContextAccessor;
        }


        public void Set(string key, string value)
        {
            var options = new CookieOptions()
            {
                Expires = DateTime.Now.AddMinutes(30),
                HttpOnly = true,
            };
            this._context.HttpContext.Response.Cookies.Append(CookieName, value, options);
        }

        string ICookie.GetCookie()
        {
            var context = this._context.HttpContext;
            return context.Request.Cookies[CookieName];
        }

        public void Delete(string key)
        {
            this._context.HttpContext.Response.Cookies.Delete(key);
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }
    }
}
