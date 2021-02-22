using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace ReinforcedConcreteFactoryBusinessLogic.Interfaces
{
    public interface IReinforcedStorage
    {
        List<ReinforcedViewModel> GetFullList();
        List<ReinforcedViewModel> GetFilteredList(ReinforcedBindingModel model);
        ReinforcedViewModel GetElement(ReinforcedBindingModel model);
        void Insert(ReinforcedBindingModel model);
        void Update(ReinforcedBindingModel model);
        void Delete(ReinforcedBindingModel model);
    }
}
