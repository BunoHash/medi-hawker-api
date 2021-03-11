using MediHawker.Data;
using MediHawker.Repositories.ConsumerCart.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Services.ConsumerCart.Implementation
{
    public class CartService
    {
        private readonly ICartRepository _cartRepository;
        public CartService (ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        public bool AddtoCart(Cart cart)
        {
            return this._cartRepository.AddToCart(cart);
    }


    }
}
