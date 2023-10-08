using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp2.Domain
{
    public class GoodItem
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal PricePerOne { get; set; }
        public decimal Price { get; set; }

        public GoodItem(string name, int count, decimal pricePerOne, decimal price)
        {
            Name = name;
            Count = count;
            PricePerOne = pricePerOne;
            Price = price;
        }
        public GoodItem()
        {
            Name = "";
            Count = 0;
            PricePerOne = 0;
            Price = 0;
        }
        public override string ToString()
        {
               return $"{Name} - {Count} x {PricePerOne} грн : {Price} грн";
        }
    }
}
