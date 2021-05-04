using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ReinforcedConcreteFactoryBusinessLogic.BindingModels
{
    [DataContract]
    public class StoreHouseBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public string StoreHouseName { get; set; }
        [DataMember]
        public string NameOfResponsiblePerson { get; set; }
        [DataMember]
        public DateTime DateCreate { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> StoreHouseMaterials { get; set; }
    }
}
