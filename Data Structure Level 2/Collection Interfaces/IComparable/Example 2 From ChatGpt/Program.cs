using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_From_ChatGpt
{

    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price); // Compare based on Price
        }

        public override string ToString() => $"{Name}: ${Price}";
    }

    public class Program
    {
        public static void Main()
        {
            SortedSet<Product> products = new SortedSet<Product>
        {
            new Product { Name = "Laptop", Price = 999.99m },
            new Product { Name = "Phone", Price = 499.99m },
            new Product { Name = "Tablet", Price = 299.99m }
        };

            Console.WriteLine("Products sorted by price:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }



    }
