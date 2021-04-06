using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.HelperModels;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ReinforcedConcreteFactoryBusinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        private readonly IMaterialStorage _materialStorage;
        private readonly IReinforcedStorage _reinforcedStorage;
        private readonly IOrderStorage _orderStorage;
        public ReportLogic(IReinforcedStorage reinforcedStorage, IMaterialStorage materialStorage, IOrderStorage orderStorage)
        {
            _reinforcedStorage = reinforcedStorage;
            _materialStorage = materialStorage;
            _orderStorage = orderStorage;
        }
/// <summary>
/// Получение списка компонент с указанием, в каких изделиях используются
/// </summary>
/// <returns></returns>
    public List<ReportReinforcedMaterialViewModel> GetReinforcedMaterials()
        {
            var materials = _materialStorage.GetFullList();
            var reinforceds = _reinforcedStorage.GetFullList();
            var list = new List<ReportReinforcedMaterialViewModel>();
            foreach (var reinforced in reinforceds)
            {
                var record = new ReportReinforcedMaterialViewModel
                {
                    ReinforcedName = reinforced.ReinforcedName,
                    ReinforcedMaterials = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var material in materials)
                {
                    if (reinforced.ReinforcedMaterial.ContainsKey(material.Id))
                    {
                        record.ReinforcedMaterials.Add(new Tuple<string, int>(material.MaterialName,
                        reinforced.ReinforcedMaterial[material.Id].Item2));
                        record.TotalCount += reinforced.ReinforcedMaterial[material.Id].Item2;
                    }
                }
                list.Add(record);
            }
            return list;
        }
        /// <summary>
        /// Получение списка заказов за определенный период
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            return _orderStorage.GetFilteredList(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            })
            .Select(x => new ReportOrdersViewModel
            {
                DateCreate = x.DateCreate,
                ReinforcedName = x.ReinforcedName,
                Count = x.Count,
                Sum = x.Sum,
                Status = x.Status
            })
           .ToList();
        }
        /// <summary>
        /// Сохранение изделий в файл-Word
        /// </summary>
        /// <param name="model"></param>
        public void SaveReinforcedToWordFile(ReportBindingModel model)
        {
            SaveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список изделий",
                Reinforceds = _reinforcedStorage.GetFullList()
            });
        }
        /// <summary>
        /// Сохранение компонент с указаеним продуктов в файл-Excel
        /// </summary>
        /// <param name="model"></param>
        public void SaveReinforcedMaterialToExcelFile(ReportBindingModel model)
        {
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Материалы по изделиям",
                ReinforcedMaterials = GetReinforcedMaterials()
            });
        }
        /// <summary>
        /// Сохранение заказов в файл-Pdf
        /// </summary>
        /// <param name="model"></param>
        public void SaveOrdersToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список заказов",
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
                Orders = GetOrders(model)
            });
        }
    }
}
