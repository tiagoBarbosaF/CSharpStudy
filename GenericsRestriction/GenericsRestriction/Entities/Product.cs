﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace GenericsRestriction.Entities
{
    class Product : IComparable
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{name}, {price.ToString("F2",CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not a Product.");
            }

            Product other = obj as Product;
            return price.CompareTo(other.price);
        }
    }
}
