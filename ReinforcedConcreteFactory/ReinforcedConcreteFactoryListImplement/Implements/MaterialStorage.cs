using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace ReinforcedConcreteFactoryListImplement.Implements
{
    public class MaterialStorage : IMaterialStorage
    {
        private readonly DataListSingleton source;
        public MaterialStorage()
        {
            source = DataListSingleton.GetInstance();
        }
        public List<MaterialViewModel> GetFullList()
        {
            List<MaterialViewModel> result = new List<MaterialViewModel>();
            foreach (Material material in source.Materials)
            {
                result.Add(CreateModel(material));
            }
            return result;
        }
        public List<MaterialViewModel> GetFilteredList(MaterialBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            List<MaterialViewModel> result = new List<MaterialViewModel>();
            foreach (Material material in source.Materials)
            {
                if (material.MaterialName.Contains(model.MaterialName))
                {
                    result.Add(CreateModel(material));
                }
            }
            return result;
        }
        public MaterialViewModel GetElement(MaterialBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (Material material in source.Materials)
            {
                if (material.Id == model.Id || material.MaterialName == model.MaterialName)
                {
                    return CreateModel(material);
                }
            }
            return null;
        }
        public void Insert(MaterialBindingModel model)
        {
            Material tempMaterial = new Material { Id = 1 };
            foreach (Material material in source.Materials)
            {
                if (material.Id >= tempMaterial.Id)
                {
                    tempMaterial.Id = material.Id + 1;
                }
            }
            source.Materials.Add(CreateModel(model, tempMaterial));
        }
        public void Update(MaterialBindingModel model)
        {
            Material tempMaterial = null;
            foreach (Material material in source.Materials)
            {
                if (material.Id == model.Id)
                {
                    tempMaterial = material;
                }
            }
            if (tempMaterial == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempMaterial);
        }
        public void Delete(MaterialBindingModel model)
        {
            for (int i = 0; i < source.Materials.Count; ++i)
            {
                if (source.Materials[i].Id == model.Id.Value)
                {
                    source.Materials.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
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
