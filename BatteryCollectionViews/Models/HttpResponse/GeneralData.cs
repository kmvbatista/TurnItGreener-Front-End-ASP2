using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatteryCollectionViews.Models.HttpResponse
{
    public class GeneralData
    {
        public string mostVisited { get; set; }
        public string mostDiscarded { get; set; }
        public int totalPoints { get; set; }
        public int mostDiscardedMonth { get; set; }
    }
}
