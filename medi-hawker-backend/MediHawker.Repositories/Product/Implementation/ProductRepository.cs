using MediHawker.Data;
using MediHawker.Repositories.Product.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MediHawker.Repositories.Product.Implementation
{
    public class ProductRepository : IProductRepository

    {
        private readonly MedihawkerDbContext _context;
        public ProductRepository(MedihawkerDbContext context)
        {
            _context = context;
        }
        public List<Generic> getAllGenericName()
        {
            List<Generic> generic = (from x in _context.Generic select x).ToList();
            return generic;
        }

        public bool Save(Products product)
        {
            try {
                if (isValidProduct(product))
                {
                    _context.ConProducts.Add(product);
                    
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }

            catch (Exception ex)
            {
                throw ex;
            }


            
        }

        private bool isValidProduct(Products product)
        {
            return true;
        }
    }
}
