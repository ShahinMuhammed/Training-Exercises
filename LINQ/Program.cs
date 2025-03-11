using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Product
    {
        public string Name, Category;
        public double Price;
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Wireless Headphones", Category = "Electronics", Price = 59 },
                new Product { Name = "Gaming Mouse", Category = "Electronics", Price = 29 },
                new Product { Name = "Office Chair", Category = "Furniture", Price = 120.10 },
                new Product { Name = "Coffee Maker", Category = "Appliances", Price = 49.9 },
                new Product { Name = "Bluetooth Speaker", Category = "Electronics", Price = 35.50 },
                new Product { Name = "Running Shoes", Category = "Footwear", Price = 79.99 },
                new Product { Name = "Smart Watch", Category = "Electronics", Price = 199.99 },
                new Product { Name = "Cookware Set", Category = "Kitchen", Price = 89.99 },
                new Product { Name = "Backpack", Category = "Accessories", Price = 45.00 },
                new Product { Name = "Desk Lamp", Category = "Furniture", Price = 22.50 }
            };

            //foreach(var p in products)
            //{
            //    Console.WriteLine($"Name = {p.Name} , Category = {p.Category} , Price = {p.Price}");
            //}
            //Console.WriteLine();
            //Console.Write("Enter the category to be selected:");
            //string choice = Console.ReadLine();
            //var filteredProducts = products.Where(p => p.Category == choice).ToList();
            //double avgPrice = filteredProducts.Count() > 0 ? filteredProducts.Average(p => p.Price) : 0;
            //Console.WriteLine("Products in category:" + choice);
            //foreach(var p in filteredProducts)
            //{
            //    Console.WriteLine($"Name = {p.Name} , Category = {p.Category} , Price = {p.Price}");
            //}
            //Console.WriteLine($"\nAverage price in {choice}: ${avgPrice}");




            var groupByCategory = from p in products
                                  group p by p.Category into g
                                  select new { Categroy = g.Key, Count = g.Count()};

            foreach(var g in groupByCategory)
            {
                Console.WriteLine($"{g.Categroy}: {g.Count} products");
            }
        }
    }
}
