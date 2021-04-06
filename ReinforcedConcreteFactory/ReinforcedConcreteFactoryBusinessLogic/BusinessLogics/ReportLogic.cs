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
        private readonly IStoreHouseStorage _storeHouseStorage;
        public ReportLogic(IReinforcedStorage reinforcedStorage, IMaterialStorage materialStorage, IOrderStorage orderStorage, IStoreHouseStorage storeHouseStorage)
        {
            _reinforcedStorage = reinforcedStorage;
            _materialStorage = materialStorage;
            _orderStorage = orderStorage;
            _storeHouseStorage = storeHouseStorage;
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

        public List<ReportStoreHouseMaterialViewModel> GetStoreHouseMaterials()
        {
            var materials = _materialStorage.GetFullList();
            var storeHouses = _storeHouseStorage.GetFullList();
            var records = new List<ReportStoreHouseMaterialViewModel>();
            foreach (var storeHouse in storeHouses)
            {
                var record = new ReportStoreHouseMaterialViewModel
                {
                    StoreHouseName = storeHouse.StoreHouseName,
                    Materials = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var material in materials)
                {
                    if (storeHouse.StoreHouseMaterials.ContainsKey(material.Id))
                    {
                        record.Materials.Add(new Tuple<string, int>(
                            material.MaterialName, storeHouse.StoreHouseMaterials[material.Id].Item2));

                        record.TotalCount += storeHouse.StoreHouseMaterials[material.Id].Item2;
                    }
                }
                records.Add(record);
            }
            return records;
        }

        public List<ReportOrdersForAllDatesViewModel> GetOrdersForAllDates()
        {
            return _orderStorage.GetFullList()
                .GroupBy(order => order.DateCreate.ToShortDateString())
                .Select(rec => new ReportOrdersForAllDatesViewModel
                {
                    Date = Convert.ToDateTime(rec.Key),
                    Count = rec.Count(),
                    Sum = rec.Sum(order => order.Sum)
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

        public void SaveStoreHousesToWordFile(ReportBindingModel model)
        {
            SaveToWord.CreateDocStoreHouse(new WordInfoStoreHouse
            {
                FileName = model.FileName,
                Title = "Список складов",
                StoreHouses = _storeHouseStorage.GetFullList()
            });
        }

        public void SaveStoreHouseMaterialsToExcelFile(ReportBindingModel model)
        {
            SaveToExcel.CreateDocStoreHouse(new ExcelInfoStoreHouse
            {
                FileName = model.FileName,
                Title = "Список складов",
                StoreHouseMaterials = GetStoreHouseMaterials()
            });
        }

        public void SaveOrdersForAllDatesToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDocOrdersForAllDates(new PdfInfoOrdersForAllDates
            {
                FileName = model.FileName,
                Title = "Список заказов",
                Orders = GetOrdersForAllDates()
            });
        }
    }
}
