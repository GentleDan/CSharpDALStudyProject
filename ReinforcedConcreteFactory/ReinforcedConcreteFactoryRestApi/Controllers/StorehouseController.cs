using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using ReinforcedConcreteFactoryBusinessLogic.BusinessLogics;

namespace ReinforcedConcreteFactoryRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StorehouseController : ControllerBase
    {
        private readonly StoreHouseLogic storeHouseLogic;
        private readonly MaterialLogic materialLogic;
        public StorehouseController(StoreHouseLogic storeHouseLogic, MaterialLogic materialLogic)
        {
            this.storeHouseLogic = storeHouseLogic;
            this.materialLogic = materialLogic;
        }
        
        public List<StoreHouseViewModel> GetAll() => storeHouseLogic.Read(null);
        
        public List<MaterialViewModel> GetAllMaterials() => materialLogic.Read(null);

        [HttpPost]
        public void Create(StoreHouseBindingModel model) => storeHouseLogic.CreateOrUpdate(model);

        [HttpPost]
        public void Update(StoreHouseBindingModel model) => storeHouseLogic.CreateOrUpdate(model);

        [HttpPost]
        public void Delete(StoreHouseBindingModel model) => storeHouseLogic.Delete(model);

        [HttpPost]
        public void AddMaterial(AddMaterialBindingModel model) => storeHouseLogic.AddMaterial(model);
    }
}
