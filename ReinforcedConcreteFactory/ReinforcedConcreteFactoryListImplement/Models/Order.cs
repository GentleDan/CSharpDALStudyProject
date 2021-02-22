using ReinforcedConcreteFactoryBusinessLogic.Enums;
using System;

namespace ReinforcedConcreteFactoryListImplement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ReinforcedId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
    }
}
