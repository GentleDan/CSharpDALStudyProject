using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReinforcedConcreteFactoryDatabaseImplement.Models
{
    public class StoreHouse
    {
        public int Id { get; set; }

        [Required]
        public string StoreHouseName { get; set; }

        [Required]
        public string NameOfResponsiblePerson { get; set; }

        [Required]
        public DateTime DateCreate { get; set; }

        [ForeignKey("StoreHouseId")]
        public virtual List<StoreHouseMaterial> StoreHouseMaterials { get; set; }
    }
}
