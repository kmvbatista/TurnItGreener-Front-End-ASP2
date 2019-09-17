using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatteryCollectionViews.Models.HttpResponse
{
    public class RootObject
    {
        public Token token { get; set; }
        public User user { get; set; }
    }
}
