﻿using System;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;
        
        public Topping(string toppingType, double weight)
        {
            this.Type = toppingType;
            this.Weight = weight;
        }
        public string Type
        {
            get { return type; }
            private set 
            {
                if (!ToppingValidator.IsValid(value.ToLower()))
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
                type = value; 
            }
        }
        
        public double Weight
        {
            get { return weight; }
            private set 
            {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{this.Type} weight should be in the range [1..50].");
                }
                weight = value; 
            }
        }

        public double GetTotalCalories()
        {
            return 2 * this.weight * ToppingValidator.GetModifier(this.Type.ToLower());
        }
    }
}
