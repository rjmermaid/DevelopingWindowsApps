using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Item> ItemsOfTheWeek { get; set; }
    }
}
