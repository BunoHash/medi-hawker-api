using MediHawker.Data;
using MediHawker.Services.ConsumerCart.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medi_hawker_api.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        [HttpPost]
        [Route("addToCart")]
        public bool AddToCart(Cart cart)
        {
            return this._cartService.AddToCart(cart);
        }
    }
}
