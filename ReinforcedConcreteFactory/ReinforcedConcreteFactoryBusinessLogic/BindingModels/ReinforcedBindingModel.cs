using System.Collections.Generic;

namespace ReinforcedConcreteFactoryBusinessLogic.BindingModels
{
    public class ReinforcedBindingModel
    {
        public int? Id { get; set; }
        public string ReinforcedName { get; set; }
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> ReinforcedMaterials { get; set; }
    }
}
