using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using ReinforcedConcreteFactoryFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReinforcedConcreteFactoryFileImplement.Implements
{
    public class ReinforcedStorage : IReinforcedStorage
    {
        private readonly FileDataListSingleton source;
        public ReinforcedStorage()
        {
            source = FileDataListSingleton.GetInstance();
        }
        public List<ReinforcedViewModel> GetFullList()
        {
            return source.Reinforceds.Select(CreateModel).ToList();
        }
        public List<ReinforcedViewModel> GetFilteredList(ReinforcedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return source.Reinforceds.Where(rec => rec.ReinforcedName.Contains(model.ReinforcedName)).Select(CreateModel).ToList();
        }
        public ReinforcedViewModel GetElement(ReinforcedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            Reinforced reinforced = source.Reinforceds.FirstOrDefault(rec => rec.ReinforcedName == model.ReinforcedName || rec.Id == model.Id);
            return reinforced != null ? CreateModel(reinforced) : null;
        }
        public void Insert(ReinforcedBindingModel model)
        {
            int maxId = source.Reinforceds.Count > 0 ? source.Materials.Max(rec => rec.Id) : 0;
            Reinforced element = new Reinforced
            {
                Id = maxId + 1,
                ReinforcedMaterials = new Dictionary<int, int>()
            };
            source.Reinforceds.Add(CreateModel(model, element));
        }
        public void Update(ReinforcedBindingModel model)
        {
            Reinforced element = source.Reinforceds.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
        }
        public void Delete(ReinforcedBindingModel model)
        {
            Reinforced element = source.Reinforceds.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                source.Reinforceds.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private Reinforced CreateModel(ReinforcedBindingModel model, Reinforced reinforced)
        {
            reinforced.ReinforcedName = model.ReinforcedName;
            reinforced.Price = model.Price;
            // удаляем убранные
            foreach (int key in reinforced.ReinforcedMaterials.Keys.ToList())
            {
                if (!model.ReinforcedMaterials.ContainsKey(key))
                {
                    reinforced.ReinforcedMaterials.Remove(key);
                }
            }
            // обновляем существуюущие и добавляем новые
            foreach (KeyValuePair<int, (string, int)> material in model.ReinforcedMaterials)
            {
                if (reinforced.ReinforcedMaterials.ContainsKey(material.Key))
                {
                    reinforced.ReinforcedMaterials[material.Key] = model.ReinforcedMaterials[material.Key].Item2;
                }
                else
                {
                    reinforced.ReinforcedMaterials.Add(material.Key, model.ReinforcedMaterials[material.Key].Item2);
                }
            }
            return reinforced;
        }
        private ReinforcedViewModel CreateModel(Reinforced reinforced)
        {
            return new ReinforcedViewModel
            {
                Id = reinforced.Id,
                ReinforcedName = reinforced.ReinforcedName,
                Price = reinforced.Price,
                ReinforcedMaterial = reinforced.ReinforcedMaterials.ToDictionary(recPC => recPC.Key, recPC =>
                (source.Materials.FirstOrDefault(recC => recC.Id == recPC.Key)?.MaterialName, recPC.Value))
            };
        }
    }
}
