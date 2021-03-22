using Microsoft.EntityFrameworkCore;
using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using ReinforcedConcreteFactoryDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ReinforcedConcreteFactoryDatabaseImplement.Implements
{
    public class ReinforcedStorage : IReinforcedStorage
    {
        public List<ReinforcedViewModel> GetFullList()
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                return context.Reinforceds.Include(rec => rec.ReinforcedMaterials).ThenInclude(rec => rec.Material).ToList().Select(rec => new ReinforcedViewModel
                {
                    Id = rec.Id,
                    ReinforcedName = rec.ReinforcedName,
                    Price = rec.Price,
                    ReinforcedMaterial = rec.ReinforcedMaterials.ToDictionary(recPC => recPC.MaterialId, recPC => (recPC.Material?.MaterialName, recPC.Count))
                }).ToList();
            }
        }
        public List<ReinforcedViewModel> GetFilteredList(ReinforcedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                return context.Reinforceds.Include(rec => rec.ReinforcedMaterials).ThenInclude(rec => rec.Material)
                .Where(rec => rec.ReinforcedName.Contains(model.ReinforcedName)).ToList().Select(rec => new ReinforcedViewModel
                {
                    Id = rec.Id,
                    ReinforcedName = rec.ReinforcedName,
                    Price = rec.Price,
                    ReinforcedMaterial = rec.ReinforcedMaterials.ToDictionary(recPC => recPC.MaterialId, recPC => (recPC.Material?.MaterialName, recPC.Count))
                }).ToList();
            }
        }
        public ReinforcedViewModel GetElement(ReinforcedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                Reinforced reinforced = context.Reinforceds.Include(rec => rec.ReinforcedMaterials).ThenInclude(rec => rec.Material)
                .FirstOrDefault(rec => rec.ReinforcedName == model.ReinforcedName || rec.Id == model.Id);
                return reinforced != null ? new ReinforcedViewModel
                {
                    Id = reinforced.Id,
                    ReinforcedName = reinforced.ReinforcedName,
                    Price = reinforced.Price,
                    ReinforcedMaterial = reinforced.ReinforcedMaterials.ToDictionary(recPC => recPC.MaterialId, recPC => (recPC.Material?.MaterialName, recPC.Count))
                } : null;
            }
        }
        public void Insert(ReinforcedBindingModel model)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                using (Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        CreateModel(model, new Reinforced(), context);
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
        public void Update(ReinforcedBindingModel model)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                using (Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Reinforced element = context.Reinforceds.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        CreateModel(model, element, context);
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
        public void Delete(ReinforcedBindingModel model)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                Reinforced element = context.Reinforceds.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Reinforceds.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        private Reinforced CreateModel(ReinforcedBindingModel model, Reinforced reinforced, ReinforcedConcreteFactoryDatabase context)
        {
            reinforced.ReinforcedName = model.ReinforcedName;
            reinforced.Price = model.Price;
            if (reinforced.Id == 0)
            {
                context.Reinforceds.Add(reinforced);
                context.SaveChanges();
            }
            if (model.Id.HasValue)
            {  
                List<ReinforcedMaterial> reinforcedMaterials = context.ReinforcedMaterials.Where(rec => rec.ReinforcedId == model.Id.Value).ToList();
                // удалили те, которых нет в модели
                context.ReinforcedMaterials.RemoveRange(reinforcedMaterials.Where(rec => !model.ReinforcedMaterials.ContainsKey(rec.MaterialId)).ToList());
                context.SaveChanges();
                // обновили количество у существующих записей
                foreach (ReinforcedMaterial updateMaterial in reinforcedMaterials)
                {
                    updateMaterial.Count = model.ReinforcedMaterials[updateMaterial.MaterialId].Item2;
                    model.ReinforcedMaterials.Remove(updateMaterial.MaterialId);
                }
                context.SaveChanges();
            }
            // добавили новые
            foreach (KeyValuePair<int, (string, int)> pc in model.ReinforcedMaterials)
            {
                context.ReinforcedMaterials.Add(new ReinforcedMaterial
                {
                    ReinforcedId = reinforced.Id,
                    MaterialId = pc.Key,
                    Count = pc.Value.Item2
                });
                context.SaveChanges();
            }
            return reinforced;
        }
    }
}
