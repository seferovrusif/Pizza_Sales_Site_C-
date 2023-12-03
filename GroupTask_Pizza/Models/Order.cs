using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GroupTask_Pizza.Models
{
    internal class Order
    {
        static private int id = 0;
        public int Id { get; }
        public string Adress { get; set; }
        public string PhoneNumber {  get; set; }
        public DateTime OrderDate { get; set; }
        public  List<Product> Basket { get; set; }

        public Order(string adress,string phonenumber,DateTime datetime,List<Product> basket)
        {
            Id= id;
            id++;
            Adress = adress;
            PhoneNumber = phonenumber;
            OrderDate = datetime;            
            Basket = basket;
        }
        public override string ToString()
        {
            string basket = "";
            Basket.ForEach(x =>basket += x+"\n");
            return $"Id=>  {Id}  Adress: {Adress}  Phone num: {PhoneNumber}  Order Date: {OrderDate}  Ordered products:\n{basket} ";
        }

    }
}
