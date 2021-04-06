using System;
using System.Collections.Generic;

namespace ReinforcedConcreteFactoryBusinessLogic.BindingModels
{
    public class StoreHouseBindingModel
    {
        public int? Id { get; set; }

        public string StoreHouseName { get; set; }

        public string NameOfResponsiblePerson { get; set; }

        public DateTime DateCreate { get; set; }

        public Dictionary<int, (string, int)> StoreHouseMaterials { get; set; }
    }
}
