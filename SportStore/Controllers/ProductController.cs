using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models.ViewModels;
using SportStoreDal.DataAccess;
using SportStoreDal.Models.ViewModels;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly StoreContext _context;

        public ProductController(StoreContext context)
        {
            _context = context;
        }
        public ViewResult List()
        {
            return View(new ProductListViewModel 
            {
                Products = _context.Products
                    .OrderBy(p => p.ProductId)
                    .Select(p => new ProductViewModel {
                        ProductId = p.ProductId,
                        Description = p.Description,
                        Name = p.Name,
                        UnitCost = p.UnitCost
                    })
            });
        }
    }
}
