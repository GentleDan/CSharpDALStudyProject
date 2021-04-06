using System.Collections.Generic;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;

namespace ReinforcedConcreteFactoryBusinessLogic.HelperModels
{
    public class ExcelInfoStoreHouse
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportStoreHouseMaterialViewModel> StoreHouseMaterials { get; set; }
    }
}
