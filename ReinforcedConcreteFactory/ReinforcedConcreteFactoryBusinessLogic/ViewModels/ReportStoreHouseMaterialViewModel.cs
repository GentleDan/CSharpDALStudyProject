using System;
using System.Collections.Generic;

namespace ReinforcedConcreteFactoryBusinessLogic.ViewModels
{
    public class ReportStoreHouseMaterialViewModel
    {
        public string StoreHouseName { get; set; }

        public int TotalCount { get; set; }

        public List<Tuple<string, int>> Materials { get; set; }
    }
}
