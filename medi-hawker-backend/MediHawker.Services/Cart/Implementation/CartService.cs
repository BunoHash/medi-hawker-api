using MediHawker.Data;
using MediHawker.Repositories.ConsumerCart.Interface;
using MediHawker.Services.ConsumerCart.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Services.ConsumerCart.Implementation
{
    public class CartService:ICartService
    {
        private readonly ICartRepository _cartRepository;
        public CartService (ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        public bool AddToCart(Cart cart)
        {
            return this._cartRepository.AddToCart(cart);
    }


    }
}
