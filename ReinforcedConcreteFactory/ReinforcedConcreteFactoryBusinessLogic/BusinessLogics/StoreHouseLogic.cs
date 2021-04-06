using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace ReinforcedConcreteFactoryBusinessLogic.BusinessLogics
{
    public class StoreHouseLogic
    {
        private readonly IStoreHouseStorage _storehouseStorage;
        private readonly IMaterialStorage _materialStorage;

        public StoreHouseLogic(IStoreHouseStorage storehouseStorage, IMaterialStorage materialStorage)
        {
            _storehouseStorage = storehouseStorage;
            _materialStorage = materialStorage;
        }

        public List<StoreHouseViewModel> Read(StoreHouseBindingModel model)
        {
            if (model == null)
            {
                return _storehouseStorage.GetFullList();
            }

            if (model.Id.HasValue)
            {
                return new List<StoreHouseViewModel> { _storehouseStorage.GetElement(model) };
            }

            return _storehouseStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(StoreHouseBindingModel model)
        {
            StoreHouseViewModel element = _storehouseStorage.GetElement(
                new StoreHouseBindingModel
                {
                    Id = model.Id
                });

            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже существует склад с идентичным названием");
            }

            if (model.Id.HasValue)
            {
                _storehouseStorage.Update(model);
            }
            else
            {
                _storehouseStorage.Insert(model);
            }
        }

        public void Delete(StoreHouseBindingModel model)
        {
            StoreHouseViewModel element = _storehouseStorage.GetElement(
                new StoreHouseBindingModel
                {
                    Id = model.Id
                });

            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }

            _storehouseStorage.Delete(model);
        }

        public void AddMaterial(AddMaterialBindingModel model)
        {
            StoreHouseViewModel storehouse = _storehouseStorage.GetElement(new StoreHouseBindingModel
            {
                Id = model.StoreHouseId
            });

            MaterialViewModel material = _materialStorage.GetElement(new MaterialBindingModel
            {
                Id = model.MaterialId
            });

            if (storehouse == null)
            {
                throw new Exception("Склад не найден");
            }

            if (material == null)
            {
                throw new Exception("Материал не найден");
            }

            Dictionary<int, (string, int)> storehouseMaterials = storehouse.StoreHouseMaterials;

            if (storehouseMaterials.ContainsKey(model.MaterialId))
            {
                storehouseMaterials[model.MaterialId] = (storehouseMaterials[model.MaterialId].Item1,
                    storehouseMaterials[model.MaterialId].Item2 + model.Count);
            }
            else
            {
                storehouseMaterials.Add(model.MaterialId, (material.MaterialName, model.Count));
            }

            _storehouseStorage.Update(new StoreHouseBindingModel
            {
                Id = storehouse.Id,
                StoreHouseName = storehouse.StoreHouseName,
                NameOfResponsiblePerson = storehouse.NameOfResponsiblePerson,
                DateCreate = storehouse.DateCreate,
                StoreHouseMaterials = storehouseMaterials
            });
        }
    }
}
