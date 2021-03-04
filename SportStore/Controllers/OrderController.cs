using Microsoft.AspNetCore.Mvc;
using SportStore.Models.ViewModels;
using SportStoreDal.DataAccess;
using SportStoreDal.Models;
using System;
using System.Linq;

namespace SportStore.Controllers
{
    public class OrderController : Controller
    {
        private StoreContext _context;
        private ShoppingCart shoppingCart;

        public OrderController(StoreContext context, ShoppingCart cartService)
        {
            _context = context;
            shoppingCart = cartService;
        }
        public ViewResult List() =>
            View(_context.Orders.Select(o => new OrderViewModel {
                City = o.City,
                Country = o.Country,
                Date = o.OrderDate,
                FullName = o.CustomerNavigation.FullName,
                OrderId = o.OrderId,
                State = o.State,
                Zip = o.Zip,
                TotalValue = o.Details.Sum(e => e.ProductNavigation.UnitCost * e.Quantity)
            }).ToList());
      
        public ViewResult Details(int orderId)
        {

            var order = _context.Orders.Select(o => new OrderViewModel
            {
                City = o.City,
                Country = o.Country,
                Date = o.OrderDate,
                FullName = o.CustomerNavigation.FullName,
                OrderId = o.OrderId,
                State = o.State,
                Zip = o.Zip,
                Lines = o.Details.Select(d => new OrderLineViewModel
                {
                    Product = new ProductViewModel
                    {
                        Name = d.ProductNavigation.Name,
                        ProductId = d.ProductId,
                        UnitCost = d.ProductNavigation.UnitCost
                    },
                    Quantity = d.Quantity
                })
            }).SingleOrDefault(o => o.OrderId == orderId);

            if(order == null)
            {
                return View("NotFound");
            }

            return View("Details", order);
        }
       
        public ViewResult Checkout() => View(new OrderViewModel());

        [HttpPost]
        public IActionResult Checkout(OrderViewModel orderModel)
        {
            if (shoppingCart.Records.Count() == 0)
            {
                ModelState.AddModelError("", "Koszyk jest pusty!");
            }

            if (ModelState.IsValid)
            {
                var order = new Order {
                    City = orderModel.City,
                    Country = orderModel.Country,
                    CustomerNavigation = new Customer
                    {
                        FullName = orderModel.FullName
                    },
                    OrderDate = DateTime.Now,
                    Details = shoppingCart.Records.Select(x => new OrderDetail
                    {
                        ProductId = x.Product.ProductId,
                        Quantity = x.Quantity
                    }).ToList(),
                    State = orderModel.State,
                    Zip = orderModel.Zip
                };

                _context.Orders.Add(order);
                _context.SaveChanges();
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(orderModel);
            }
        }

        public ViewResult Completed()
        {
            shoppingCart.Clear();
            return View();
        }

    }
}
