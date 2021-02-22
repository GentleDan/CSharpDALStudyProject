using System.Collections.Generic;
using System.ComponentModel;

namespace ReinforcedConcreteFactoryBusinessLogic.ViewModels
{
    public class ReinforcedViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название изделия")]
        public string ReinforcedName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> ReinforcedMaterial { get; set; }
    }
}
