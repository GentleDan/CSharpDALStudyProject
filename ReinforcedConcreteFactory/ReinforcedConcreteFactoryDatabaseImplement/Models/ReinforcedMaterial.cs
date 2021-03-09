using System.ComponentModel.DataAnnotations;

namespace ReinforcedConcreteFactoryDatabaseImplement.Models
{
    public class ReinforcedMaterial
    {
        public int Id { get; set; }
        public int ReinforcedId { get; set; }
        public int MaterialId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Material Material { get; set; }
        public virtual Reinforced Reinforced { get; set; }

    }
}
