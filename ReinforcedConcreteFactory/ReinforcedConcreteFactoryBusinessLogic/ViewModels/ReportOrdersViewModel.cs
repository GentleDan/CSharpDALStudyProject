using ReinforcedConcreteFactoryBusinessLogic.Enums;
using System;

namespace ReinforcedConcreteFactoryBusinessLogic.ViewModels
{
    public class ReportOrdersViewModel
    {
        public DateTime DateCreate { get; set; }
        public string ReinforcedName { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public OrderStatus Status { get; set; }
    }
}
