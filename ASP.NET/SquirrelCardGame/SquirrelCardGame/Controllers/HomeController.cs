using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SquirrelCardGame.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SquirrelCardGame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("_Board");
        }
        public ActionResult Start()
        {
            Game game = new Game();
            Player Player1 = game.Player1;
            Player1.Hand = new List<Card>();

            // Show Hand on the screen
            return PartialView("_Board");
        }

        public ActionResult PickCard()
        {
            // public Game game;
            // GetCard
            // Game.Go(chosenCard) = isOver; Show a message of the result
            // Show new Hand 
            return PartialView("_Board");
        }
    }
}
