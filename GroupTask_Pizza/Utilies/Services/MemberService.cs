using GroupTask_Pizza.Models;
using GroupTask_Pizza.Utilies.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskff.Utilies.Exceptions;

namespace GroupTask_Pizza.Utilies.Services
{
    internal class MemberService
    {
        public static void GetPizzaCatalog()
        {
            Database.Products.ForEach(x => Console.WriteLine(x));
        }

        public static void ListsOfBasket()
        {
            order.Basket.ForEach(x => Console.WriteLine(x));
        }
        public static void ListsOfOrdered()
        {
            Database.OrdersList.ForEach(x => Console.WriteLine(x));
        }



        static Order order = new Order(null, null, default, new List<Product>() { });
        public static List<(int, int)> BasketTemp = new List<(int, int)>();
        public static bool CompleteOrder = true;

        public static void AddToCart()
        {
            Console.WriteLine("Sifarish etmek istediyiniz pizza Id-sini daxil edin: ");
            int idd = Convert.ToInt32(Console.ReadLine());
            var a = Database.Products.Find(x => x.Id == idd);
            if (a == null)
            {
                throw new PizzaNotFoundException("Pizza Tapilmadi");
            }
            else
            {
                Console.WriteLine("Pizza sayini daxil et");
                int say = Convert.ToInt32(Console.ReadLine());
                if (say <= a.Count && say > 0)
                {
                    Product orderedPizza = new Product(a.Name, a.Price, say);
                    order.Basket.Add(orderedPizza);
                    BasketTemp.Add((a.Id, say));
                    CompleteOrder = false;
                }
                else
                {
                    throw new ("Mehsul sayi yanlisdir");

                }
            }
        }
        public static void DoOrder()
        {
            if (order.Basket.Count == 0)
            {
                Console.WriteLine("Sebet boshdur!");
            }
            else
            {
                ListsOfBasket();
                decimal TotalPrice = 0;
                order.Basket.ForEach(x => TotalPrice += x.Price * x.Count);
                Console.WriteLine($"Umumi mebleg: {TotalPrice:C}");
                Console.WriteLine("Unvani daxil edin:");
                string adress = Console.ReadLine();
                Console.WriteLine("Telefon nomresini daxil edin");
                string phonenumber = Console.ReadLine();
                while (!OrderValidation.PhoneValidation(phonenumber))
                {

                    Console.WriteLine("Nomre sehvdir, yeniden daxil edin:");
                    phonenumber = Console.ReadLine();
                }
                order = new Order(adress, phonenumber, DateTime.Now, order.Basket);
                Database.OrdersList.Add(order);
                order = new Order(null, null, default, new List<Product>() { });
                Console.WriteLine("Sifarish tamamlandi!");
                CompleteOrder = true;
                CompletedOrder();
                BasketTemp.Clear();


            }
        }

        public static void CompletedOrder()
        {
            //order = new Order(null, null, default, new List<Product>() { });
            //order.Id--;
            foreach (var item in BasketTemp)
            {
                foreach (var prod in Database.Products)
                {
                    if (item.Item1 == prod.Id)
                    {
                        prod.Count -= item.Item2;
                    }
                }
            }
        }
        public static void UnCompletedOrder()
        {
            order = new Order(null, null, default, new List<Product>() { });

        }


    }
}
