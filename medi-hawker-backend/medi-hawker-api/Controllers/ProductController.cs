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
        [Route("getAllGenericName")]

        public List<Generic> GetAllGenericName()
        {
            return _productService.getAllGenericName();
        }

        [HttpPost]
        [Route("saveProduct")]

        public bool saveProduct(Products product)
        {
            return this._productService.Save(product);
        }

        [HttpGet]
        [Route("getSavedProduct")]
        public List<Products>GetSavedProduct()
        {
            return _productService.getSavedProduct();
        }
    }
}
