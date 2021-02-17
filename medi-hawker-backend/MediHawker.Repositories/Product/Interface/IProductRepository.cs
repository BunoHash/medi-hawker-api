using MediHawker.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Repositories.Product.Interface
{
    public interface IProductRepository
    {
        List<Generic> getAllGenericName();
    }
}
