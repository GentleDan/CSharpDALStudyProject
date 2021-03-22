using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ReinforcedConcreteFactoryDatabaseImplement.Models
{
    public class Material
    {
        public int Id { get; set; }
        [Required]
        public string MaterialName { get; set; }
        [ForeignKey("MaterialId")]
        public virtual List<ReinforcedMaterial> ReinforcedMaterials { get; set; }
        [ForeignKey("MaterialId")]
        public virtual List<StoreHouseMaterial> StoreHouseMaterials { get; set; }
    }
}
