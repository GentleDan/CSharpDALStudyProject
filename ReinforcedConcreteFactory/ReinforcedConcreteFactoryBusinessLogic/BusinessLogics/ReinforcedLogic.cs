using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace ReinforcedConcreteFactoryBusinessLogic.BusinessLogics
{
    public class ReinforcedLogic
    {
        private readonly IReinforcedStorage _reinforcedStorage;
        public ReinforcedLogic(IReinforcedStorage reinforcedStorage)
        {
            _reinforcedStorage = reinforcedStorage;
        }
        public List<ReinforcedViewModel> Read(ReinforcedBindingModel model)
        {
            if (model == null)
            {
                return _reinforcedStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ReinforcedViewModel> { _reinforcedStorage.GetElement(model)
};
            }
            return _reinforcedStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(ReinforcedBindingModel model)
        {
            ReinforcedViewModel element = _reinforcedStorage.GetElement(new ReinforcedBindingModel
            {
                ReinforcedName = model.ReinforcedName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть изделие с таким названием");
            }
            if (model.Id.HasValue)
            {
                _reinforcedStorage.Update(model);
            }
            else
            {
                _reinforcedStorage.Insert(model);
            }
        }
        public void Delete(ReinforcedBindingModel model)
        {
            ReinforcedViewModel element = _reinforcedStorage.GetElement(new ReinforcedBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _reinforcedStorage.Delete(model);
        }
    }
}
