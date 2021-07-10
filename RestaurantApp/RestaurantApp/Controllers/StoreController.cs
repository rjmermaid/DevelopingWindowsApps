using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Controllers
{
    public class StoreController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        // Using DI to get the configuration object from the app and the AppDbContext
        public StoreController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Categories.OrderBy(c => c.CategoryName).ToList());
        }
        public IActionResult Items(int id)
        {
            var items = _dbContext.Items.Where(i => i.CategoryId == id).ToList();
            return View(items);
        }
    }
}
