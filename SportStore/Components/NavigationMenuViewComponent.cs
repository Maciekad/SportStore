using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportStoreDal.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly StoreContext _context;

        public NavigationMenuViewComponent(StoreContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Categories
                .Select(x=>x.CategoryName)
                .Distinct()
                .OrderBy(x=>x));
        }
    }
}
