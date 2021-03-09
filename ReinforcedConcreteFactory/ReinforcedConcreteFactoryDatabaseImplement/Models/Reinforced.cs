using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReinforcedConcreteFactoryDatabaseImplement.Models
{
    public class Reinforced
    {
        public int Id { get; set; }
        [Required]
        public string ReinforcedName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [ForeignKey("ReinforcedId")]
        public virtual List<ReinforcedMaterial> ReinforcedMaterials { get; set; }
        [ForeignKey("ReinforcedId")]
        public virtual List<Order> Orders { get; set; }
    }
}
