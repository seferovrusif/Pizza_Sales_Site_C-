using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTask_Pizza.Models
{
    internal class Product
    {
        static int _id = 1;
        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count {  get; set; }
        public Product(string name, decimal price, int count)
        {
            Id = _id;
            _id++;
            Name = name;
            Price = price;
            Count = count;
        }

        public override string ToString()
        {
            return $"Id=> {Id}  Name: {Name}  Price: {Price:C}  Count: {Count}";
        }
    }
}
