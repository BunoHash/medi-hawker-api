using MediHawker.Data;
using MediHawker.Services.Product.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medi_hawker_api.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        [Route("GetAllProducts")]

        public List<Generic> GetAllGenericName()
        {
            return _productService.getAllGenericName();
        }
    }
}
