using System;
using System.Collections.Generic;

namespace ExercicioTimeshare
{
    public class Product
    {

        public string Name { get; }
        public double Price { get; }
       


        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            
            
        }
    }
}