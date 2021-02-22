using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReinforcedConcreteFactoryListImplement.Implements
{
    public class ReinforcedStorage : IReinforcedStorage
    {
        private readonly DataListSingleton source;
        public ReinforcedStorage()
        {
            source = DataListSingleton.GetInstance();
        }
        public List<ReinforcedViewModel> GetFullList()
        {
            List<ReinforcedViewModel> result = new List<ReinforcedViewModel>();
            foreach (Reinforced reinforced in source.Reinforceds)
            {
                result.Add(CreateModel(reinforced));
            }
            return result;
        }
        public List<ReinforcedViewModel> GetFilteredList(ReinforcedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            List<ReinforcedViewModel> result = new List<ReinforcedViewModel>();
            foreach (Reinforced reinforced in source.Reinforceds)
            {
                if (reinforced.ReinforcedName.Contains(model.ReinforcedName))
                {
                    result.Add(CreateModel(reinforced));
                }
            }
            return result;
        }
        public ReinforcedViewModel GetElement(ReinforcedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (Reinforced reinforced in source.Reinforceds)
            {
                if (reinforced.Id == model.Id || reinforced.ReinforcedName == model.ReinforcedName)
                {
                    return CreateModel(reinforced);
                }
            }
            return null;
        }
        public void Insert(ReinforcedBindingModel model)
        {
            Reinforced tempReinforced = new Reinforced
            {
                Id = 1,
                ReinforcedMaterials = new Dictionary<int, int>()
            };
            foreach (Reinforced reinforced in source.Reinforceds)
            {
                if (reinforced.Id >= tempReinforced.Id)
                {
                    tempReinforced.Id = reinforced.Id + 1;
                }
            }
            source.Reinforceds.Add(CreateModel(model, tempReinforced));
        }
        public void Update(ReinforcedBindingModel model)
        {
            Reinforced tempReinforced = null;
            foreach (Reinforced reinforced in source.Reinforceds)
            {
                if (reinforced.Id == model.Id)
                {
                    tempReinforced = reinforced;
                }
            }
            if (tempReinforced == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempReinforced);
        }
        public void Delete(ReinforcedBindingModel model)
        {
            for (int i = 0; i < source.Reinforceds.Count; ++i)
            {
                if (source.Reinforceds[i].Id == model.Id)
                {
                    source.Reinforceds.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
        private Reinforced CreateModel(ReinforcedBindingModel model, Reinforced reinforced)
        {
            reinforced.ReinforcedName = model.ReinforcedName;
            reinforced.Price = model.Price;
            // удаляем убранные
            foreach (int key in reinforced.ReinforcedMaterials.Keys.ToList())
            {
                if (!model.ReinforcedMaterial.ContainsKey(key))
                {
                    reinforced.ReinforcedMaterials.Remove(key);
                }
            }
            // обновляем существуюущие и добавляем новые
            foreach (KeyValuePair<int, (string, int)> component in model.ReinforcedMaterial)
            {
                if (reinforced.ReinforcedMaterials.ContainsKey(component.Key))
                {
                    reinforced.ReinforcedMaterials[component.Key] = model.ReinforcedMaterial[component.Key].Item2;
                }
                else
                {
                    reinforced.ReinforcedMaterials.Add(component.Key, model.ReinforcedMaterial[component.Key].Item2);
                }
            }
            return reinforced;
        }
        private ReinforcedViewModel CreateModel(Reinforced reinforced)
        {
            // требуется дополнительно получить список компонентов для изделия сназваниями и их количествоm
            Dictionary<int, (string, int)> reinforcedMaterials = new Dictionary<int, (string, int)>();
            foreach (KeyValuePair<int, int> pc in reinforced.ReinforcedMaterials)
            {
                string materialName = string.Empty;
                foreach (Material material in source.Materials)
                {
                    if (pc.Key == material.Id)
                    {
                        materialName = material.MaterialName;
                        break;
                    }
                }
                reinforcedMaterials.Add(pc.Key, (materialName, pc.Value));
            }
            return new ReinforcedViewModel
            {
                Id = reinforced.Id,
                ReinforcedName = reinforced.ReinforcedName,
                Price = reinforced.Price,
                ReinforcedMaterial = reinforcedMaterials
            };
        }
    }
}
