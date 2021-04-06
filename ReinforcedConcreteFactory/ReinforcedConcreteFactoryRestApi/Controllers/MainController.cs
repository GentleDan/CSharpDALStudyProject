using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.BusinessLogics;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ReinforcedConcreteFactoryRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly OrderLogic _order;
        private readonly ReinforcedLogic _reinforced;
        private readonly OrderLogic _main;
        public MainController(OrderLogic order, ReinforcedLogic travel, OrderLogic main)
        {
            _order = order;
            _reinforced = travel;
            _main = main;
        }

        [HttpGet]
        public List<ReinforcedViewModel> GetReinforcedList() => _reinforced.Read(null)?.ToList();

        [HttpGet]
        public ReinforcedViewModel GetReinforced(int reinforcedId) => _reinforced.Read(new ReinforcedBindingModel
        { Id = reinforcedId })?[0];

        [HttpGet]
        public List<OrderViewModel> GetOrders(int clientId) => _order.Read(new OrderBindingModel
        { ClientId = clientId });

        [HttpPost]
        public void CreateOrder(CreateOrderBindingModel model) => _main.CreateOrder(model);
    }
}
