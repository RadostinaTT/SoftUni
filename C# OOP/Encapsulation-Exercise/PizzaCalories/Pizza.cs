using System;
using System.Linq;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }
        public string Name
        {
            get { return name; }
            private set 
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
                name = value; 
            }
        }

        public Dough Dough { get; }

        public int ToppingsCount
            => this.toppings.Count;

        public double TotalCalories
            => toppings.Sum(x => x.GetTotalCalories()) + this.Dough.GetTotalCalories();

        public void AddTopping(Topping topping)
        {
            if (this.ToppingsCount < 10)
            {
                toppings.Add(topping);
            }
            else
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
            
        }
    }
}
