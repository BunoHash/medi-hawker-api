using MediHawker.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Repositories.ConsumerCart.Interface
{
   public interface ICartRepository
    {
        bool AddToCart(Cart cart);
        
    }
}
