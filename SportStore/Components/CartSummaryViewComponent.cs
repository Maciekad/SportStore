using Microsoft.AspNetCore.Mvc;
using SportStoreDal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private ShoppingCart shoppingCart;

        public CartSummaryViewComponent(ShoppingCart cartService)
        {
            shoppingCart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(shoppingCart);
        }
    }
}
