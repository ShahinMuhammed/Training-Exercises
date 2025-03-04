using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ECommerceTask
{
    class Program
    {

        public class Product
        {
            public int Id, Quantity;
            public string Name;
            public double Price;
            public Product(int id, string name, double price, int quantity)
            {
                Id = id;
                Name = name;
                Price = price;
                Quantity = quantity;

            }
            public void displayProduct()
            {
                Console.WriteLine($"ID: {Id}, Name: {Name}, Price: {Price}, Quantity: {Quantity}");
            }
        }

        class ShoppingCart 
        {
            private List<Product> items = new List<Product>();
            private Product[] availableItems;

            public ShoppingCart(Product[] products)
            {
                availableItems = products;
            }

            
            public void AddProducts()
            {
                Console.Write("Which product would you like to add(enter Id):");
                int pnum = Convert.ToInt32(Console.ReadLine());

                Product selectedProduct = Array.Find(availableItems, p => p.Id == pnum);
                if (selectedProduct != null)
                {
                    items.Add(new Product(selectedProduct.Id, selectedProduct.Name,selectedProduct.Price,selectedProduct.Quantity));
                    Console.WriteLine("Item Added");
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }
                
            }
            public void RemoveProducts()
            {
                Console.Write("Which product would you like to remove(Enter Id):");
                int pnum = Convert.ToInt32(Console.ReadLine());

                Product productRemove = Array.Find(availableItems, p => p.Id == pnum);
                if (productRemove != null)
                {
                    items.Remove(productRemove);
                    Console.WriteLine("Product removed");
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }

                
            }
            public void DisplayCart()
            {
                if (items.Count == null)
                {
                    Console.WriteLine("Cart is empty");
                    return;
                }
                else
                {
                    foreach (Product p in items)
                    {
                        p.displayProduct();
                    }
                }
                    

            }
            public void CalculateTotal()
            {
                 double totalPrice=0;
                if (items.Count == null)
                {
                    Console.WriteLine("No product is selected");

                }
                else
                {
                    foreach (Product p in items)
                    {
                        totalPrice += p.Price;
                    }
                    Console.WriteLine($"The total price is {totalPrice}");
                }
            }
        }

        static void Main(string[] args)
        {

            try
            {

                Product[] products = new Product[]
                {
                new Product(1, "product1", 99.9, 1),
                new Product(2, "product2", 10.50, 1),
                new Product(3, "product3", 30.60, 1),
                new Product(4, "product4", 50.05, 1),
                };

                ShoppingCart sc = new ShoppingCart(products);

                int choice;

                do
                {

                    Console.WriteLine("1.Display Products\t2.AddProduct\t3.RemoveProduct\t4.DisplayCart\t5.CalculateTotal\t6.Exit");
                    Console.Write("Enter your choice:");

                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            foreach(Product p in products)
                            {
                                p.displayProduct();
                            }
                            Console.WriteLine();
                            break;
                        case 2:
                            sc.AddProducts();
                            break;
                        case 3:
                            sc.RemoveProducts();
                            break;

                        case 4:
                            sc.DisplayCart();
                            break;
                        case 5:
                            sc.CalculateTotal();
                            break;

                        case 6:
                            return;

                    }

                } while (choice != 6);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
            
        }
    }
}
