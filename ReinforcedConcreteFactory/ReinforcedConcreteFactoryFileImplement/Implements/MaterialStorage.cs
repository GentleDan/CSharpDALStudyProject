using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using ReinforcedConcreteFactoryFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ReinforcedConcreteFactoryFileImplement.Implements
{
    public class MaterialStorage : IMaterialStorage
    {
        private readonly FileDataListSingleton source;
        public MaterialStorage()
        {
            source = FileDataListSingleton.GetInstance();
        }
        public List<MaterialViewModel> GetFullList()
        {
            return source.Materials.Select(CreateModel).ToList();
        }
        public List<MaterialViewModel> GetFilteredList(MaterialBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return source.Materials.Where(rec => rec.MaterialName.Contains(model.MaterialName)).Select(CreateModel).ToList();
        }
        public MaterialViewModel GetElement(MaterialBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            Material material = source.Materials.FirstOrDefault(rec => rec.MaterialName == model.MaterialName || rec.Id == model.Id);
            return material != null ? CreateModel(material) : null;
        }
        public void Insert(MaterialBindingModel model)
        {
            int maxId = source.Materials.Count > 0 ? source.Materials.Max(rec => rec.Id) : 0;
            Material element = new Material { Id = maxId + 1 };
            source.Materials.Add(CreateModel(model, element));
        }
        public void Update(MaterialBindingModel model)
        {
            Material element = source.Materials.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
        }
        public void Delete(MaterialBindingModel model)
        {
            Material element = source.Materials.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                source.Materials.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private Material CreateModel(MaterialBindingModel model, Material material)
        {
            material.MaterialName = model.MaterialName;
            return material;
        }
        private MaterialViewModel CreateModel(Material material)
        {
            return new MaterialViewModel
            {
                Id = material.Id,
                MaterialName = material.MaterialName
            };
        }
    }
}
