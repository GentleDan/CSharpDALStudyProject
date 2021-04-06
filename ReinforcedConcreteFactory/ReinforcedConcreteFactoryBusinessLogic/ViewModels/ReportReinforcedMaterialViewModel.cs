using System;
using System.Collections.Generic;

namespace ReinforcedConcreteFactoryBusinessLogic.ViewModels
{
    public class ReportReinforcedMaterialViewModel
    {
        public string ReinforcedName { get; set; }
        public int TotalCount { get; set; }
        public List<Tuple<string, int>> ReinforcedMaterials { get; set; }
    }
}
