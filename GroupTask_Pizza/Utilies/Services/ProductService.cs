using GroupTask_Pizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTask_Pizza.Utilies.Services
{
    internal class ProductService
    {
        public static void AddProduct(string name, decimal price, int count)
        {
            Product product = new Product(name, price, count);
            Database.Products.Add(product);
        }
        public static Product GetProductById(int id)
        {
            return Database.Products.Find(p => p.Id == id);
        }
        public static void UpdateProduct(int id)
        {
            Product a = GetProductById(id);
            Console.WriteLine(a);
            Console.WriteLine("1. Change Name\n2. Change Price\n3. Change Count");
            string b = Console.ReadLine();
            switch (b)
            {
                case "1":
                    Console.WriteLine("New Name: ");
                    a.Name = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("New Price: ");
                    a.Price = Convert.ToDecimal(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("New Count: ");
                    a.Count = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        public static void GetAllProducts()
        {
            Database.Products.ForEach(u => Console.WriteLine(u));
        }
        public static void RemoveProduct(int id)
        {
            Database.Products.Remove(GetProductById(id));
        }
    }
}
