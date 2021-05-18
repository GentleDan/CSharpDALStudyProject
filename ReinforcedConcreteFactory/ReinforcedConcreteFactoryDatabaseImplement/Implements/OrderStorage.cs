using Microsoft.EntityFrameworkCore;
using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.Enums;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using ReinforcedConcreteFactoryDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReinforcedConcreteFactoryDatabaseImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                return context.Orders.Include(rec => rec.Reinforced).Include(rec => rec.Client).Include(rec => rec.Implementer)
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    ClientId = rec.ClientId,
                    ClientFIO = rec.Client.ClientFIO,
                    ImplementerId = rec.ImplementerId,
                    ImplementerFIO = rec.Implementer.ImplementerFIO,
                    ReinforcedId = rec.ReinforcedId,
                    ReinforcedName = rec.Reinforced.ReinforcedName,
                    Count = rec.Count,
                    Sum = rec.Sum,
                    Status = rec.Status,
                    DateCreate = rec.DateCreate,
                    DateImplement = rec.DateImplement,
                })
                .ToList();
            }
        }
        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                return context.Orders.Include(rec => rec.Reinforced).Include(rec => rec.Client).Include(rec => rec.Implementer)
                .Where(rec => (!model.DateFrom.HasValue && !model.DateTo.HasValue &&
                rec.DateCreate.Date == model.DateCreate.Date) ||
                (model.DateFrom.HasValue && model.DateTo.HasValue &&
                rec.DateCreate.Date >= model.DateFrom.Value.Date && rec.DateCreate.Date <=
                model.DateTo.Value.Date) || (model.ClientId.HasValue && rec.ClientId == model.ClientId) ||
                (model.FreeOrders.HasValue && model.FreeOrders.Value && rec.Status ==
                OrderStatus.Принят) || (model.ImplementerId.HasValue && rec.ImplementerId == model.ImplementerId && rec.Status == model.Status))
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    ClientId = rec.ClientId,
                    ClientFIO = rec.Client.ClientFIO,
                    ImplementerId = rec.ImplementerId,
                    ImplementerFIO = rec.Implementer.ImplementerFIO,
                    ReinforcedId = rec.ReinforcedId,
                    ReinforcedName = rec.Reinforced.ReinforcedName,
                    Count = rec.Count,
                    Sum = rec.Sum,
                    Status = rec.Status,
                    DateCreate = rec.DateCreate,
                    DateImplement = rec.DateImplement,
                })
                .ToList();
            }
        }
        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                Order order = context.Orders.Include(rec => rec.Reinforced).Include(rec => rec.Client).Include(rec => rec.Implementer)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return order != null ?
                new OrderViewModel
                {
                    Id = order.Id,
                    ClientId = order.ClientId,
                    ClientFIO = order.Client.ClientFIO,
                    ImplementerId = order.ImplementerId,
                    ImplementerFIO = order.ImplementerId.HasValue ? order.Implementer.ImplementerFIO : string.Empty,
                    ReinforcedId = order.ReinforcedId,
                    ReinforcedName = order.Reinforced.ReinforcedName,
                    Count = order.Count,
                    Sum = order.Sum,
                    Status = order.Status,
                    DateCreate = order.DateCreate,
                    DateImplement = order.DateImplement
                } :
                null;
            }
        }
        public void Insert(OrderBindingModel model)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                context.Orders.Add(CreateModel(model, new Order()));
                context.SaveChanges();
            }
        }
        public void Update(OrderBindingModel model)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                var order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (order == null)
                {
                    throw new Exception("Заказ не найден");
                }
                CreateModel(model, order);
                context.SaveChanges();
            }
        }
        public void Delete(OrderBindingModel model)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                Order order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Заказ не найден");
                }
            }
        }
        private Order CreateModel(OrderBindingModel model, Order order)
        {
            order.ClientId = (int)model.ClientId;
            order.ReinforcedId = model.ReinforcedId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.ImplementerId = model.ImplementerId;
            order.DateImplement = model.DateImplement;
            return order;
        }
    }
}
