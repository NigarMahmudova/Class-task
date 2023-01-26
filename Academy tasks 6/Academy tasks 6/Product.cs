using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_tasks_6
{
    class Product
    {
        public Product(string name, double price, int discountPercant=0)
        {
            Name = name;
            Price = price;
            DiscountPercent = discountPercant;
        }
        
        public string Name;
        public double Price;
        public int DiscountPercent;


    }
}
