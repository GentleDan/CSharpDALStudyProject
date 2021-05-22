using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.Enums;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using ReinforcedConcreteFactoryListImplement.Models;
using System;
using System.Collections.Generic;

namespace ReinforcedConcreteFactoryListImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        private readonly DataListSingleton source;
        public OrderStorage()
        {
            source = DataListSingleton.GetInstance();
        }
        public List<OrderViewModel> GetFullList()
        {
            List<OrderViewModel> result = new List<OrderViewModel>();
            foreach (Order component in source.Orders)
            {
                result.Add(CreateModel(component));
            }
            return result;
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            List<OrderViewModel> result = new List<OrderViewModel>();
            foreach (Order order in source.Orders)
            {
                if ((!model.DateFrom.HasValue && !model.DateTo.HasValue && order.DateCreate.Date == model.DateCreate.Date)
                    || (model.DateFrom.HasValue && model.DateTo.HasValue && order.DateCreate.Date >= model.DateFrom.Value.Date && order.DateCreate.Date <= model.DateTo.Value.Date)
                    || (model.ClientId.HasValue && order.ClientId == model.ClientId)
                    || (model.FreeOrders.HasValue && model.FreeOrders.Value && !order.ImplementerId.HasValue)
                    || (model.FreeOrders.HasValue && model.FreeOrders.Value && order.Status == OrderStatus.Принят)
                    || (model.ImplementerId.HasValue && order.ImplementerId == model.ImplementerId && order.Status == OrderStatus.Выполняется)
                    || (model.ImplementerId.HasValue && order.ImplementerId == model.ImplementerId && order.Status == OrderStatus.Требуются_материалы))
                {
                    result.Add(CreateModel(order));
                }
            }
            return result;
        }
        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (Order order in source.Orders)
            {
                if (order.Id == model.Id || order.ReinforcedId == model.ReinforcedId)
                {
                    return CreateModel(order);
                }
            }
            return null;
        }
        public void Insert(OrderBindingModel model)
        {
            Order tempComponent = new Order { Id = 1 };
            foreach (Order component in source.Orders)
            {
                if (component.Id >= tempComponent.Id)
                {
                    tempComponent.Id = component.Id + 1;
                }
            }
            source.Orders.Add(CreateModel(model, tempComponent));
        }
        public void Update(OrderBindingModel model)
        {
            Order tempComponent = null;
            foreach (Order component in source.Orders)
            {
                if (component.Id == model.Id)
                {
                    tempComponent = component;
                }
            }
            if (tempComponent == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempComponent);
        }
        public void Delete(OrderBindingModel model)
        {
            for (int i = 0; i < source.Orders.Count; ++i)
            {
                if (source.Orders[i].Id == model.Id.Value)
                {
                    source.Orders.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
        private Order CreateModel(OrderBindingModel model, Order order)
        {
            order.ClientId = (int) model.ClientId;
            order.ImplementerId = model.ImplementerId;
            order.ReinforcedId = model.ReinforcedId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            return order;
        }
        private OrderViewModel CreateModel(Order order)
        {
            string reinforcedName = null;
            foreach (Reinforced reinforced in source.Reinforceds)
            {
                if (reinforced.Id == order.ReinforcedId)
                {
                    reinforcedName = reinforced.ReinforcedName;
                }
            }
            string clientFIO = null;
            foreach (var client in source.Clients)
            {
                if (client.Id == order.ClientId)
                {
                    clientFIO = client.ClientFIO;
                }
            }
            string implementerFIO = null;
            foreach (var implementer in source.Implementers)
            {
                if (implementer.Id == order.ImplementerId)
                {
                    implementerFIO = implementer.ImplementerFIO;
                }
            }
            return new OrderViewModel
            {
                Id = order.Id,
                ClientId = order.ClientId,
                ClientFIO = clientFIO,
                ImplementerId = order.ImplementerId,
                ImplementerFIO = implementerFIO,
                ReinforcedId = order.ReinforcedId,
                ReinforcedName = reinforcedName,
                Count = order.Count,
                Sum = order.Sum,
                DateCreate = order.DateCreate,
                Status = order.Status,
                DateImplement = order.DateImplement
            };
        }
    }
}
