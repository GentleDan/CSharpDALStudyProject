using ReinforcedConcreteFactoryFileImplement.Models;
using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReinforcedConcreteFactoryFileImplement.Implements
{
    public class StoreHouseStorage : IStoreHouseStorage
    {
        private readonly FileDataListSingleton source;

        public StoreHouseStorage()
        {
            source = FileDataListSingleton.GetInstance();
        }

        private StoreHouse CreateModel(StoreHouseBindingModel model, StoreHouse storehouse)
        {
            storehouse.StoreHouseName = model.StoreHouseName;
            storehouse.NameOfResponsiblePerson = model.NameOfResponsiblePerson;

            foreach (var key in storehouse.StoreHouseMaterials.Keys.ToList())
            {
                if (!model.StoreHouseMaterials.ContainsKey(key))
                {
                    storehouse.StoreHouseMaterials.Remove(key);
                }
            }

            foreach (var material in model.StoreHouseMaterials)
            {
                if (storehouse.StoreHouseMaterials.ContainsKey(material.Key))
                {
                    storehouse.StoreHouseMaterials[material.Key] =
                        model.StoreHouseMaterials[material.Key].Item2;
                }
                else
                {
                    storehouse.StoreHouseMaterials.Add(material.Key, model.StoreHouseMaterials[material.Key].Item2);
                }
            }

            return storehouse;
        }

        private StoreHouseViewModel CreateModel(StoreHouse storehouse)
        {
            Dictionary<int, (string, int)> storehouseMaterials = new Dictionary<int, (string, int)>();

            foreach (var storehouseMaterial in storehouse.StoreHouseMaterials)
            {
                string materialName = string.Empty;
                foreach (var material in source.Materials)
                {
                    if (storehouseMaterial.Key == material.Id)
                    {
                        materialName = material.MaterialName;
                        break;
                    }
                }
                storehouseMaterials.Add(storehouseMaterial.Key, (materialName, storehouseMaterial.Value));
            }

            return new StoreHouseViewModel
            {
                Id = storehouse.Id,
                StoreHouseName = storehouse.StoreHouseName,
                NameOfResponsiblePerson = storehouse.NameOfResponsiblePerson,
                DateCreate = storehouse.DateCreate,
                StoreHouseMaterials = storehouseMaterials
            };
        }

        public List<StoreHouseViewModel> GetFullList()
        {
            return source.StoreHouses.Select(CreateModel).ToList();
        }

        public List<StoreHouseViewModel> GetFilteredList(StoreHouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            return source.StoreHouses.Where(xStoreHouse => xStoreHouse.StoreHouseName.Contains(model.StoreHouseName)).Select(CreateModel).ToList();
        }

        public StoreHouseViewModel GetElement(StoreHouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            var storehouse = source.StoreHouses.FirstOrDefault(xStoreHouse => xStoreHouse.StoreHouseName == model.StoreHouseName || xStoreHouse.Id == model.Id);

            return storehouse != null ? CreateModel(storehouse) : null;
        }

        public void Insert(StoreHouseBindingModel model)
        {
            int maxId = source.StoreHouses.Count > 0 ? source.StoreHouses.Max(xStoreHouse => xStoreHouse.Id) : 0;
            var storehouse = new StoreHouse { Id = maxId + 1, StoreHouseMaterials = new Dictionary<int, int>(), DateCreate = DateTime.Now };
            source.StoreHouses.Add(CreateModel(model, storehouse));
        }

        public void Update(StoreHouseBindingModel model)
        {
            var storehouse = source.StoreHouses.FirstOrDefault(xStoreHouse => xStoreHouse.Id == model.Id);

            if (storehouse == null)
            {
                throw new Exception("Склад не найден");
            }

            CreateModel(model, storehouse);
        }

        public void Delete(StoreHouseBindingModel model)
        {
            var storehouse = source.StoreHouses.FirstOrDefault(xStoreHouse => xStoreHouse.Id == model.Id);

            if (storehouse != null)
            {
                source.StoreHouses.Remove(storehouse);
            }
            else
            {
                throw new Exception("Склад не найден");
            }
        }

        public bool TakeFromStoreHouse(Dictionary<int, (string, int)> materials, int reinforcedCount)
        {
            foreach (var storehouseMaterial in materials)
            {
                int count = source.StoreHouses.Where(material => material.StoreHouseMaterials.ContainsKey(storehouseMaterial.Key)).Sum(material => material.StoreHouseMaterials[storehouseMaterial.Key]);

                if (count < storehouseMaterial.Value.Item2 * reinforcedCount)
                {
                    return false;
                }
            }

            foreach (var storehouseMaterial in materials)
            {
                int count = storehouseMaterial.Value.Item2 * reinforcedCount;
                IEnumerable<StoreHouse> storehouses = source.StoreHouses.Where(material => material.StoreHouseMaterials.ContainsKey(storehouseMaterial.Key));

                foreach (StoreHouse storehouse in storehouses)
                {
                    if (storehouse.StoreHouseMaterials[storehouseMaterial.Key] <= count)
                    {
                        count -= storehouse.StoreHouseMaterials[storehouseMaterial.Key];
                        storehouse.StoreHouseMaterials.Remove(storehouseMaterial.Key);
                    }
                    else
                    {
                        storehouse.StoreHouseMaterials[storehouseMaterial.Key] -= count;
                        count = 0;
                    }

                    if (count == 0)
                    {
                        break;
                    }
                }
            }

            return true;
        }
    }
}
