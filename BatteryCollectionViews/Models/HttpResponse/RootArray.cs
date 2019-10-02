using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatteryCollectionViews.Models.HttpResponse
{
    public class RootArray
    {
        public Alldiscards alldiscards { get; set; }
        public GeneralData generalData { get; set; }
        public List<MaterialsDiscarded> materialsDiscarded { get; set; }
    }
}
