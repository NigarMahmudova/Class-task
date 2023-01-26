using System;
using System.Collections.Generic;
using System.Text;

namespace Class__constructor
{
    internal class Notebook
    {
        public Notebook(string brand, string model, double price = 0) 
        { 
            Brand = brand;
            Model = model;
            Price = price;
        }
        
        public string Brand;
        public string Model;
        public double Price;

        public string ShowInfo()
        {
            return $"Brand: {Brand} - Model: {Model} - Price: {Price}";
        }
    }
}
