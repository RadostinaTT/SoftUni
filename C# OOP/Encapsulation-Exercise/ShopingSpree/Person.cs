﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name,decimal money)
        {
            this.Name = name;
            this.Money = money;
            bag = new List<Product>();
        }
        public string Name {
            get { return name; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value; 
            }
        }
        public decimal Money
        {
            get { return money; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                } 
                money = value; 
            }
        }

        public IReadOnlyCollection<Product> Bag
            => this.bag.AsReadOnly();

        public void AddToBag(Product product)
        {
            if (this.Money - product.Cost >= 0)
            {
                bag.Add(product);
                this.Money -= product.Cost;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            if (this.Bag.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            
            return $"{this.Name} - {string.Join(", ", this.Bag.Select(x => x.Name))}";
        }
    }
}
