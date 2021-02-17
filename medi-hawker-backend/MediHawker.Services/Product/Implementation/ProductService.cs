using MediHawker.Data;
using MediHawker.Repositories.Product.Interface;
using MediHawker.Services.Product.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Services.Product.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Generic> getAllGenericName()
        {
            return _productRepository.getAllGenericName();
        }
    }
}
