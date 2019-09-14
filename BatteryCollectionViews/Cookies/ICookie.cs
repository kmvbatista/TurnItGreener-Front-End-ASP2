using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatteryCollectionViews.Cookies
{
    public interface ICookie
    {
        void Set(string key, string value);
        string GetCookie();
        void Delete(string key);
        void DeleteAll();
    }
}
