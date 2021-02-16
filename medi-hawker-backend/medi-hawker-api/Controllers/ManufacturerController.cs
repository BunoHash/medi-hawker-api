using MediHawker.Data;
using MediHawker.Services.Manufacture.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medi_hawker_api.Controllers
{
    [Route("api/manufacturer")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _manufactureService;
        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufactureService = manufacturerService;

        }
        [HttpGet]
        [Route("getAllManufacturer")]
        public List<Manufacturer>GetAllManufacturer()
        {
            return _manufactureService.getAllManufacturer();
        }
        //[HttpPost]
        //[Route("saveItemInfo")]
        //public bool saveItemInfo()
        //{
        //    var response = this._manufactureService.Save();
        //    return response;
        //}

         
    }
    
}
