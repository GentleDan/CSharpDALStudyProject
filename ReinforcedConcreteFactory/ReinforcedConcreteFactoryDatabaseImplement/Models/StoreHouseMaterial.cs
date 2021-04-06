using System.ComponentModel.DataAnnotations;

namespace ReinforcedConcreteFactoryDatabaseImplement.Models
{
    public class StoreHouseMaterial
    {
        public int Id { get; set; }

        public int MaterialId { get; set; }

        public int StoreHouseId { get; set; }

        [Required]
        public int Count { get; set; }

        public virtual Material Material { get; set; }

        public virtual StoreHouse StoreHouse { get; set; }
    }
}
