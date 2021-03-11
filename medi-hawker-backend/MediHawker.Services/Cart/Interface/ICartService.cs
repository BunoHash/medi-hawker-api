using MediHawker.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Services.ConsumerCart.Interface
{
   public interface ICartService
    {
        bool AddToCart(Cart cart);
    }
    
}
