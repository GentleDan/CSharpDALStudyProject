using System.Collections.Generic;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;

namespace ReinforcedConcreteFactoryBusinessLogic.HelperModels
{
    public class WordInfoStoreHouse
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<StoreHouseViewModel> StoreHouses { get; set; }
    }
}
