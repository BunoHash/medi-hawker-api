using MediHawker.Data;
using MediHawker.Repositories.ConsumerCart.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Repositories.ConsumerCart.Implementation
{
   public class CartRepository:ICartRepository
    {
        private readonly MedihawkerDbContext _context;
        public CartRepository(MedihawkerDbContext context)
        {
            _context = context;
        }
        public bool AddToCart(Cart cart)
        {
            try
            {
                _context.Cart.Add(cart);
                _context.SaveChanges();
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;

        }
    }
}
