using Microsoft.EntityFrameworkCore;
using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReinforcedConcreteFactoryDatabaseImplement.Implements
{
    public class StoreHouseStorage : IStoreHouseStorage
    {
        private StoreHouse CreateModel(StoreHouseBindingModel model, StoreHouse storehouse, ReinforcedConcreteFactoryDatabase context)
        {
            storehouse.StoreHouseName = model.StoreHouseName;
            storehouse.NameOfResponsiblePerson = model.NameOfResponsiblePerson;

            if (storehouse.Id == 0)
            {
                storehouse.DateCreate = DateTime.Now;
                context.StoreHouses.Add(storehouse);
                context.SaveChanges();
            }

            if (model.Id.HasValue)
            {
                List<StoreHouseMaterial> StoreHouseMaterials = context.StoreHouseMaterials
                    .Where(rec => rec.StoreHouseId == model.Id.Value)
                    .ToList();

                context.StoreHouseMaterials.RemoveRange(StoreHouseMaterials
                    .Where(rec => !model.StoreHouseMaterials.ContainsKey(rec.MaterialId))
                    .ToList());
                context.SaveChanges();

                foreach (StoreHouseMaterial updateMaterial in StoreHouseMaterials)
                {
                    updateMaterial.Count = model.StoreHouseMaterials[updateMaterial.MaterialId].Item2;
                    model.StoreHouseMaterials.Remove(updateMaterial.MaterialId);
                }
                context.SaveChanges();
            }


            foreach (KeyValuePair<int, (string, int)> StoreHouseMaterial in model.StoreHouseMaterials)
            {
                context.StoreHouseMaterials.Add(new StoreHouseMaterial
                {
                    StoreHouseId = storehouse.Id,
                    MaterialId = StoreHouseMaterial.Key,
                    Count = StoreHouseMaterial.Value.Item2
                });
                context.SaveChanges();
            }

            return storehouse;
        }

        public List<StoreHouseViewModel> GetFullList()
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                return context.StoreHouses
                    .Include(rec => rec.StoreHouseMaterials)
                    .ThenInclude(rec => rec.Material)
                    .ToList()
                    .Select(rec => new StoreHouseViewModel
                    {
                        Id = rec.Id,
                        StoreHouseName = rec.StoreHouseName,
                        NameOfResponsiblePerson = rec.NameOfResponsiblePerson,
                        DateCreate = rec.DateCreate,
                        StoreHouseMaterials = rec.StoreHouseMaterials
                            .ToDictionary(recStoreHouseMaterials => recStoreHouseMaterials.MaterialId,
                            recStoreHouseMaterials => (recStoreHouseMaterials.Material?.MaterialName,
                            recStoreHouseMaterials.Count))
                    })
                    .ToList();
            }
        }

        public List<StoreHouseViewModel> GetFilteredList(StoreHouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                return context.StoreHouses
                    .Include(rec => rec.StoreHouseMaterials)
                    .ThenInclude(rec => rec.Material)
                    .Where(rec => rec.StoreHouseName.Contains(model.StoreHouseName))
                    .ToList()
                    .Select(rec => new StoreHouseViewModel
                    {
                        Id = rec.Id,
                        StoreHouseName = rec.StoreHouseName,
                        NameOfResponsiblePerson = rec.NameOfResponsiblePerson,
                        DateCreate = rec.DateCreate,
                        StoreHouseMaterials = rec.StoreHouseMaterials
                            .ToDictionary(recStoreHouseMaterial => recStoreHouseMaterial.MaterialId,
                            recStoreHouseMaterial => (recStoreHouseMaterial.Material?.MaterialName,
                            recStoreHouseMaterial.Count))
                    })
                    .ToList();
            }
        }

        public StoreHouseViewModel GetElement(StoreHouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                StoreHouse StoreHouse = context.StoreHouses
                    .Include(rec => rec.StoreHouseMaterials)
                    .ThenInclude(rec => rec.Material)
                    .FirstOrDefault(rec => rec.StoreHouseName == model.StoreHouseName ||
                    rec.Id == model.Id);

                return StoreHouse != null ?
                    new StoreHouseViewModel
                    {
                        Id = StoreHouse.Id,
                        StoreHouseName = StoreHouse.StoreHouseName,
                        NameOfResponsiblePerson = StoreHouse.NameOfResponsiblePerson,
                        DateCreate = StoreHouse.DateCreate,
                        StoreHouseMaterials = StoreHouse.StoreHouseMaterials
                            .ToDictionary(recStoreHouseMaterial => recStoreHouseMaterial.MaterialId,
                            recStoreHouseMaterial => (recStoreHouseMaterial.Material?.MaterialName,
                            recStoreHouseMaterial.Count))
                    } :
                    null;
            }
        }

        public void Insert(StoreHouseBindingModel model)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                using (Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        CreateModel(model, new StoreHouse(), context);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Update(StoreHouseBindingModel model)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                using (Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        StoreHouse storehouse = context.StoreHouses.FirstOrDefault(rec => rec.Id == model.Id);

                        if (storehouse == null)
                        {
                            throw new Exception("Склад не найден");
                        }

                        CreateModel(model, storehouse, context);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Delete(StoreHouseBindingModel model)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                StoreHouse storehouse = context.StoreHouses.FirstOrDefault(rec => rec.Id == model.Id);

                if (storehouse == null)
                {
                    throw new Exception("Склад не найден");
                }
                context.StoreHouses.Remove(storehouse);
                context.SaveChanges();
            }
        }

        public bool TakeFromStoreHouse(Dictionary<int, (string, int)> materials, int reinforcedCount)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                using (Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (KeyValuePair<int, (string, int)> storeHouseMaterial in materials)
                        {
                            int count = storeHouseMaterial.Value.Item2 * reinforcedCount;
                            IEnumerable<StoreHouseMaterial> storeHouseMaterials = context.StoreHouseMaterials.Where(storehouse => storehouse.MaterialId == storeHouseMaterial.Key);
                            int availableCount = storeHouseMaterials.Sum(storehouse => storehouse.Count);
                            if (availableCount < count)
                            {
                                throw new Exception("На складе недостаточно материалов");
                            }

                            foreach (StoreHouseMaterial material in storeHouseMaterials)
                            {
                                if (material.Count <= count)
                                {
                                    count -= material.Count;
                                    context.StoreHouseMaterials.Remove(material);
                                    context.SaveChanges();
                                }
                                else
                                {
                                    material.Count -= count;
                                    context.SaveChanges();
                                    count = 0;
                                }

                                if (count == 0)
                                {
                                    break;
                                }
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
