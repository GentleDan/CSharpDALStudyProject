using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace ReinforcedConcreteFactoryBusinessLogic.Interfaces
{
    public interface IStoreHouseStorage
    {
        List<StoreHouseViewModel> GetFullList();

        List<StoreHouseViewModel> GetFilteredList(StoreHouseBindingModel model);

        StoreHouseViewModel GetElement(StoreHouseBindingModel model);

        void Insert(StoreHouseBindingModel model);

        void Update(StoreHouseBindingModel model);

        void Delete(StoreHouseBindingModel model);

        bool TakeFromStoreHouse(Dictionary<int, (string, int)> materials, int reinforcedCount);
    }
}
