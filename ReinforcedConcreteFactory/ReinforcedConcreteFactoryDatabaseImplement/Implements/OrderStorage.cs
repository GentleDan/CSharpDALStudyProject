using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
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
                return context.Orders
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    ReinforcedId = rec.ReinforcedId,
                    ReinforcedName = context.Reinforceds.FirstOrDefault(pr => pr.Id == rec.ReinforcedId).ReinforcedName,
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
                return context.Orders
                .Where(rec => rec.ReinforcedId == model.ReinforcedId)
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    ReinforcedId = rec.ReinforcedId,
                    ReinforcedName = context.Reinforceds.FirstOrDefault(pr => pr.Id == rec.ReinforcedId).ReinforcedName,
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
                Order order = context.Orders
                .FirstOrDefault(rec => rec.Id == model.Id);
                return order != null ?
                new OrderViewModel
                {
                    Id = order.Id,
                    ReinforcedId = order.ReinforcedId,
                    ReinforcedName = context.Reinforceds.FirstOrDefault(rec => rec.Id == order.ReinforcedId)?.ReinforcedName,
                    Count = order.Count,
                    Sum = order.Sum,
                    Status = order.Status,
                    DateCreate = order.DateCreate,
                    DateImplement = order.DateImplement,
                } :
                null;
            }
        }
        public void Insert(OrderBindingModel model)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                Order order = new Order
                {
                    ReinforcedId = model.ReinforcedId,
                    Count = model.Count,
                    Sum = model.Sum,
                    Status = model.Status,
                    DateCreate = model.DateCreate,
                    DateImplement = model.DateImplement,
                };
                context.Orders.Add(order);
                context.SaveChanges();
                CreateModel(model, order);
                context.SaveChanges();
            }
        }
        public void Update(OrderBindingModel model)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                element.ReinforcedId = model.ReinforcedId;
                element.Count = model.Count;
                element.Sum = model.Sum;
                element.Status = model.Status;
                element.DateCreate = model.DateCreate;
                element.DateImplement = model.DateImplement;
                CreateModel(model, element);
                context.SaveChanges();
            }
        }
        public void Delete(OrderBindingModel model)
        {
            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Orders.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        private Order CreateModel(OrderBindingModel model, Order order)
        {
            if (model == null)
            {
                return null;
            }

            using (ReinforcedConcreteFactoryDatabase context = new ReinforcedConcreteFactoryDatabase())
            {
                Reinforced element = context.Reinforceds.FirstOrDefault(rec => rec.Id == model.ReinforcedId);
                if (element != null)
                {
                    if (element.Orders == null)
                    {
                        element.Orders = new List<Order>();
                    }
                    element.Orders.Add(order);
                    context.Reinforceds.Update(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
            return order;
        }
    }
}
