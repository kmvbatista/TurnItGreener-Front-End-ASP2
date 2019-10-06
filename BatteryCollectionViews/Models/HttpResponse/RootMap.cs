using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatteryCollectionViews.Models.HttpResponse
{
    public class RootMap
    {
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}
