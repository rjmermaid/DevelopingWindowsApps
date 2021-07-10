using RestaurantApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class DBInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Items.Any())
            {
                context.AddRange
                (
                    new Item { Name = "Luger Burger", Price = 12.95M, Description = "Our famous burger!",  Category = Categories["Burgers"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = true, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg" },
                    new Item { Name = "Vanilla", Price = 18.95M, Description = "You'll love it!",  Category = Categories["Drinks"], ImageUrl = "https://www.cookswithcocktails.com/wp-content/uploads/Coffee-1.jpg", InStock = true, ImageThumbnailUrl = "https://www.cookswithcocktails.com/wp-content/uploads/Coffee-1.jpg" },
                    new Item { Name = "Chocolate", Price = 18.95M, Description = "You'll love it!",  Category = Categories["Drinks"], ImageUrl = "https://media.self.com/photos/58988ad2fc1087d526ccb7be/4:3/w_728,c_limit/starbucks-thumb.jpg", InStock = true, ImageThumbnailUrl = "https://media.self.com/photos/58988ad2fc1087d526ccb7be/4:3/w_728,c_limit/starbucks-thumb.jpg" },
                    new Item { Name = "Burger + Fries", Price = 15.95M, Description = "Our Halloween Favorite!",  Category = Categories["Combos"], ImageUrl = "https://i.dailymail.co.uk/i/pix/2017/11/08/16/4623608900000578-0-image-a-9_1510156892900.jpg", InStock = true, ImageThumbnailUrl = "https://i.dailymail.co.uk/i/pix/2017/11/08/16/4623608900000578-0-image-a-9_1510156892900.jpg" },
                    new Item { Name = "Le Pigeon Burger", Price = 13.95M, Description = "Our famous burger!",  Category = Categories["Burgers"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = true, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg" },
                    new Item { Name = "Double Animal Style", Price = 17.95M, Description = "Our famous burger!",  Category = Categories["Burgers"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = true, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg" },
                    new Item { Name = "The Original Burger", Price = 15.95M, Description = "Our famous burger!",  Category = Categories["Burgers"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = false, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg" },
                    new Item { Name = "Mango", Price = 12.95M, Description = "You'll love it!",  Category = Categories["Drinks"], ImageUrl = "http://www.bombaytasty.com/wp-content/uploads/2014/10/Mango-Lassi.jpg", InStock = true, ImageThumbnailUrl = "http://www.bombaytasty.com/wp-content/uploads/2014/10/Mango-Lassi.jpg" },
                    new Item { Name = "Burger + Fries + Drink", Price = 15.95M, Description = "Our Halloween Favorite!",  Category = Categories["Combos"], ImageUrl = "http://image.posta.com.mx/sites/default/files/9616591eff8c54c0778c907617c14488.jpg", InStock = true, ImageThumbnailUrl = "http://image.posta.com.mx/sites/default/files/9616591eff8c54c0778c907617c14488.jpg" },
                    new Item { Name = "Pomegranate", Price = 15.95M, Description = "You'll love it!",  Category = Categories["Drinks"], ImageUrl = "https://www.vibrantplate.com/wp-content/uploads/2018/01/Pommegranate-juice-06.jpg", InStock = true, ImageThumbnailUrl = "https://www.vibrantplate.com/wp-content/uploads/2018/01/Pommegranate-juice-06.jpg" },
                    new Item { Name = "Big Mac", Price = 18.95M, Description = "Our famous burger!",  Category = Categories["Burgers"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = false, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg" }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Burgers" },
                        new Category { CategoryName = "Combos" },
                        new Category { CategoryName = "Drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }

}
