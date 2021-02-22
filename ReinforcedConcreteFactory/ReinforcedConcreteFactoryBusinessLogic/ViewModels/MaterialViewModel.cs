using System.ComponentModel;

namespace ReinforcedConcreteFactoryBusinessLogic.ViewModels
{
    public class MaterialViewModel
    {
        public int Id { get; set; }
        [DisplayName("Наименование материала")]
        public string MaterialName { get; set; }
    }
}
