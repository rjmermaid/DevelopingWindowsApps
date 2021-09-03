using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartId { get; set; }
        public string CustomerId { get; set; }
        public List<Item> ShoppingCartItems { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Purchased { get; set; }
        public bool IsActive { get; set; } 
    }
}
