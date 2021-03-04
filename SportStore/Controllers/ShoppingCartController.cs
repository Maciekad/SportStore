using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStoreDal.DataAccess;
using SportStoreDal.Models;
using SportStore.Infrastructure;
using SportStoreDal.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly StoreContext _context;
        private ShoppingCart shoppingCart;

        public ShoppingCartController(StoreContext context, ShoppingCart cartService)
        {
            _context = context;
            shoppingCart = cartService;
        }

        public ViewResult Index()
        {
            return View(new ShoppingCartIndexViewModel
            {
                ShoppingCart = shoppingCart,

            });
        }

        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            ProductViewModel product = _context.Products.Select(p =>
            new ProductViewModel {
                Name = p.Name,
                ProductId = p.ProductId,
                UnitCost = p.UnitCost
            })
            .FirstOrDefault(p => p.ProductId == productId);

            if(product != null)
            {
                shoppingCart.AddItem(product, 1); 
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            Product product = _context.Products
                              .FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                shoppingCart.RemoveRecord(product.ProductId);             
            }
            return RedirectToAction("Index");

        }

        private ShoppingCart GetCart()
        {
            ShoppingCart cart = HttpContext.Session.GetJson<ShoppingCart>("Cart") ?? new ShoppingCart();
            return cart;
        }

        private void SaveCart(ShoppingCart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }

    }
}
