using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace ReinforcedConcreteFactoryBusinessLogic.ViewModels
{
    [DataContract]
    public class StoreHouseViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [DisplayName("Название склада")]
        public string StoreHouseName { get; set; }
        [DataMember]
        [DisplayName("ФИО ответственного")]
        public string NameOfResponsiblePerson { get; set; }
        [DataMember]
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> StoreHouseMaterials { get; set; }
    }
}
