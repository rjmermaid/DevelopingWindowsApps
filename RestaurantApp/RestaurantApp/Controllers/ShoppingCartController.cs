using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantApp.Data;
using RestaurantApp.Models;

namespace RestaurantApp.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ShoppingCart
        public IActionResult Index()
        {
            string CustomerId = GetCustomerId();
            ShoppingCart shoppingCart = _context.ShoppingCarts.Where(s => s.CustomerId == CustomerId).FirstOrDefault();
            if(shoppingCart == null)
            {
                shoppingCart = new ShoppingCart();
                shoppingCart.Created = DateTime.UtcNow;
                shoppingCart.IsActive = true;
                shoppingCart.ShoppingCartItems = new List<Item>();

                _context.ShoppingCarts.Add(shoppingCart);
                _context.SaveChanges();
            }
            return View(shoppingCart);
        }

        public RedirectResult AddToCart(int id)
        {
            string CustomerId = GetCustomerId();
            Item item = _context.Items.Where(i => i.ItemId == id).FirstOrDefault();
            ShoppingCart shoppingCart = _context.ShoppingCarts.Where(s => s.CustomerId == CustomerId).FirstOrDefault();
            if (shoppingCart == null)
            {
                shoppingCart = new ShoppingCart();
                shoppingCart.CustomerId = CustomerId;
             //   shoppingCart.Created = DateTime.UtcNow;
                shoppingCart.IsActive = true;
                shoppingCart.ShoppingCartItems = new List<Item>();

                _context.ShoppingCarts.Add(shoppingCart);
                _context.SaveChanges();
            }
            if (item == null)
                shoppingCart.ShoppingCartItems.Add(item);

            _context.SaveChanges();

            return Redirect("/ShoppingCart");
        }

        public string GetCustomerId()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("CustomerId")))
            {
                string customerId = "";
                if (User.Identity.IsAuthenticated)
                {
                    customerId = User.Identity.Name;
                }
                else
                {
                    customerId = Guid.NewGuid().ToString();
                }
                HttpContext.Session.SetString("CustomerId", customerId);           
            }
            return HttpContext.Session.GetString("CustomerId");
        }
    }
}
