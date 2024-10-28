using System;
using System.Collections.Generic;

namespace Menu
{
    class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> menuItems = new List<MenuItem>
            {
                new MenuItem {
                    Name = "Caesar Salad",
                    Price = 7.99,
                    Description = "Lettuce, croutons, Parmesan cheese, and Caesar dressing.",
                    Category = "Appetizer",
                    IsNew = false
                },
                
                new MenuItem {
                    Name = "Grilled Salmon",
                    Price = 18.99,
                    Description = "Grilled salmon served with roasted vegetables.",
                    Category = "Main Course",
                    IsNew = true
                },
                
                new MenuItem {
                    Name = "Chocolate Lava Cake", Price = 8.99,
                    Description = "Rich chocolate cake with a molten chocolate center, served warm with vanilla ice cream.",
                    Category = "Dessert",
                    IsNew = false
                }
            };

            DateTime lastUpdated = DateTime.Now;

            Console.WriteLine("Restaurant Menu (Last Updated: " + lastUpdated.ToString("MM/dd/yyyy") + ")");
            Console.WriteLine();

            foreach (MenuItem item in menuItems)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("  Price: $" + item.Price.ToString("0.00"));
                Console.WriteLine("  Description: " + item.Description);
                Console.WriteLine("  Category: " + item.Category);
                Console.WriteLine((item.IsNew ? " *** NEW! ***" : ""));
                Console.WriteLine();
            }
        }
    }
}