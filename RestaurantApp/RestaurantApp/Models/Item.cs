using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class Item
    {
        public int ItemId { get; set; }

        [Required] // Not null field
        public string Name { get; set; }

        [Required]
        [Range(1.0, 500.0)]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        // 1 to many relationship
        public int CategoryId { get; set; }
        // Trick > for easier access of data
        public Category Category { get; set; }
        public string ImageUrl { get; set; }
        public bool InStock { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public List<ShoppingCart> shoppingCarts { get; set; }
    }
}
