using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Controllers
{
    public class HomeController : Controller
    {
        
        public ViewResult Index()
        {
            return View();
        }
    }
}
