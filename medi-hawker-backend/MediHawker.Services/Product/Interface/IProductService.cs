using MediHawker.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Services.Product.Interface
{
    public interface IProductService
    {
        List<Generic> getAllGenericName();
        bool Save(Products product);
        List<Products> getSavedProduct();
    }
}
