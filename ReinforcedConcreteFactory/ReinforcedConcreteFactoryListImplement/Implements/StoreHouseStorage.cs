using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using ReinforcedConcreteFactoryListImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReinforcedConcreteFactoryListImplement.Implements
{
    public class StoreHouseStorage : IStoreHouseStorage
    {
        private readonly DataListSingleton source;

        public StoreHouseStorage()
        {
            source = DataListSingleton.GetInstance();
        }

        private StoreHouse CreateModel(StoreHouseBindingModel model, StoreHouse storehouse)
        {
            storehouse.StoreHouseName = model.StoreHouseName;
            storehouse.NameOfResponsiblePerson = model.NameOfResponsiblePerson;

            foreach (int key in storehouse.StoreHouseMaterials.Keys.ToList())
            {
                if (!model.StoreHouseMaterials.ContainsKey(key))
                {
                    storehouse.StoreHouseMaterials.Remove(key);
                }
            }

            foreach (KeyValuePair<int, (string, int)> material in model.StoreHouseMaterials)
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

            foreach (KeyValuePair<int, int> storehouseMaterial in storehouse.StoreHouseMaterials)
            {
                string materialName = string.Empty;
                foreach (Material material in source.Materials)
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

        public void Delete(StoreHouseBindingModel model)
        {
            for (int i = 0; i < source.StoreHouses.Count; ++i)
            {
                if (source.StoreHouses[i].Id == model.Id)
                {
                    source.StoreHouses.RemoveAt(i);
                    return;
                }
            }

            throw new Exception("Элемент не найден");
        }

        public StoreHouseViewModel GetElement(StoreHouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            foreach (StoreHouse storehouse in source.StoreHouses)
            {
                if (storehouse.Id == model.Id)
                {
                    return CreateModel(storehouse);
                }
            }

            return null;
        }

        public List<StoreHouseViewModel> GetFilteredList(StoreHouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            List<StoreHouseViewModel> result = new List<StoreHouseViewModel>();
            foreach (StoreHouse storehouse in source.StoreHouses)
            {
                if (storehouse.StoreHouseName.Contains(model.StoreHouseName))
                {
                    result.Add(CreateModel(storehouse));
                }
            }
            return result;
        }

        public List<StoreHouseViewModel> GetFullList()
        {
            List<StoreHouseViewModel> result = new List<StoreHouseViewModel>();
            foreach (StoreHouse storehouse in source.StoreHouses)
            {
                result.Add(CreateModel(storehouse));
            }
            return result;
        }

        public void Insert(StoreHouseBindingModel model)
        {
            StoreHouse tempStoreHouse = new StoreHouse
            {
                Id = 1,
                StoreHouseMaterials = new Dictionary<int, int>(),
                DateCreate = DateTime.Now
            };

            foreach (StoreHouse storehouse in source.StoreHouses)
            {
                if (storehouse.Id >= tempStoreHouse.Id)
                {
                    tempStoreHouse.Id = storehouse.Id + 1;
                }
            }

            source.StoreHouses.Add(CreateModel(model, tempStoreHouse));
        }

        public void Update(StoreHouseBindingModel model)
        {
            StoreHouse tempStoreHouse = null;

            foreach (StoreHouse storehouse in source.StoreHouses)
            {
                if (storehouse.Id == model.Id)
                {
                    tempStoreHouse = storehouse;
                }
            }

            if (tempStoreHouse == null)
            {
                throw new Exception("Элемент не найден");
            }

            CreateModel(model, tempStoreHouse);
        }

        public void Print()
        {
            foreach (StoreHouse storehouse in source.StoreHouses)
            {
                Console.WriteLine(storehouse.StoreHouseName + " " + storehouse.NameOfResponsiblePerson + " " + storehouse.DateCreate);
                foreach (KeyValuePair<int, int> keyValue in storehouse.StoreHouseMaterials)
                {
                    string materialName = source.Materials.FirstOrDefault(material => material.Id == keyValue.Key).MaterialName;
                    Console.WriteLine(materialName + " " + keyValue.Value);
                }
            }
        }
    }
}
