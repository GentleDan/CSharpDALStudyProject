using System;
using System.Collections.Generic;

namespace ReinforcedConcreteFactoryListImplement.Models
{
    public class StoreHouse
    {
        public int Id { get; set; }
        public string StoreHouseName { get; set; }
        public string NameOfResponsiblePerson { get; set; }
        public DateTime DateCreate { get; set; }
        public Dictionary<int, int> StoreHouseMaterials { get; set; }
    }
}
