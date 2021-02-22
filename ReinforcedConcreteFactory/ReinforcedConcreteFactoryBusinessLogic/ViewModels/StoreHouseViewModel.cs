using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ReinforcedConcreteFactoryBusinessLogic.ViewModels
{
    public class StoreHouseViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название склада")]
        public string StoreHouseName { get; set; }

        [DisplayName("ФИО ответственного")]
        public string NameOfResponsiblePerson { get; set; }

        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }

        public Dictionary<int, (string, int)> StoreHouseMaterials { get; set; }
    }
}
