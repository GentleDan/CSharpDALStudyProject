using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ReinforcedConcreteFactoryAppStoreHouse.Models;
using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;

namespace ReinforcedConcreteFactoryAppStoreHouse.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            if (!Program.Authorization)
            {
                return Redirect("~/Home/Privacy");
            }

            return View(APIClient.GetRequest<List<StoreHouseViewModel>>($"api/storehouse/getall"));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public void Privacy(string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                Program.Authorization = password == configuration["Password"];

                if (!Program.Authorization)
                {
                    throw new Exception("Неверный пароль");
                }

                Response.Redirect("Index");
                return;
            }

            throw new Exception("Введите пароль");
        }

        public IActionResult Create()
        {
            if (!Program.Authorization)
            {
                return Redirect("~/Home/Privacy");
            }
            return View();
        }

        [HttpPost]
        public void Create([Bind("StoreHouseName, NameOfResponsiblePerson")] StoreHouseBindingModel model)
        {
            if (string.IsNullOrEmpty(model.StoreHouseName) || string.IsNullOrEmpty(model.NameOfResponsiblePerson))
            {
                return;
            }
            model.StoreHouseMaterials = new Dictionary<int, (string, int)>();
            APIClient.PostRequest("api/storehouse/create", model);
            Response.Redirect("Index");
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storehouse = APIClient.GetRequest<List<StoreHouseViewModel>>(
                $"api/storehouse/getall").FirstOrDefault(rec => rec.Id == id);
            if (storehouse == null)
            {
                return NotFound();
            }

            return View(storehouse);
        }

        [HttpPost]
        public IActionResult Update(int id, [Bind("Id,StoreHouseName,NameOfResponsiblePerson")] StoreHouseBindingModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            var storehouse = APIClient.GetRequest<List<StoreHouseViewModel>>(
                $"api/storehouse/getall").FirstOrDefault(rec => rec.Id == id);

            model.StoreHouseMaterials = storehouse.StoreHouseMaterials;

            APIClient.PostRequest("api/storehouse/update", model);
            return Redirect("~/Home/Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storehouse = APIClient.GetRequest<List<StoreHouseViewModel>>(
                $"api/storehouse/getall").FirstOrDefault(rec => rec.Id == id);
            if (storehouse == null)
            {
                return NotFound();
            }

            return View(storehouse);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            APIClient.PostRequest("api/storehouse/delete", new StoreHouseBindingModel { Id = id });
            return Redirect("~/Home/Index");
        }

        public IActionResult AddMaterial()
        {
            if (!Program.Authorization)
            {
                return Redirect("~/Home/Privacy");
            }
            ViewBag.Storehouses = APIClient.GetRequest<List<StoreHouseViewModel>>("api/storehouse/getall");
            ViewBag.Materials = APIClient.GetRequest<List<MaterialViewModel>>($"api/storehouse/getallmaterials");

            return View();
        }

        [HttpPost]
        public IActionResult AddMaterial([Bind("StoreHouseId, MaterialId, Count")] AddMaterialBindingModel model)
        {
            if (model.StoreHouseId == 0 || model.MaterialId == 0 || model.Count <= 0)
            {
                return NotFound();
            }

            var storehouse = APIClient.GetRequest<List<StoreHouseViewModel>>(
                "api/storehouse/getall").FirstOrDefault(rec => rec.Id == model.StoreHouseId);

            if (storehouse == null)
            {
                return NotFound();
            }

            var material = APIClient.GetRequest<List<StoreHouseViewModel>>(
                "api/storehouse/getallmaterials").FirstOrDefault(rec => rec.Id == model.MaterialId);

            if (material == null)
            {
                return NotFound();
            }

            APIClient.PostRequest("api/storehouse/addmaterial", model);
            return Redirect("~/Home/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
