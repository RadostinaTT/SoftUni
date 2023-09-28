using System;
using System.Linq;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] inputPizza = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string pizzaName = inputPizza[1];
                

                string[] inputDough = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string flourType = inputDough[1];
                string bakingTechnique = inputDough[2];
                double weightDough = double.Parse(inputDough[3]);

                Dough dough = new Dough(flourType, bakingTechnique, weightDough);
                //Console.WriteLine($"{dough.GetTotalCalories():f2}");
                Pizza pizza = new Pizza(pizzaName, dough);

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] inputTopping = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                    string toppingType = inputTopping[1];
                    double weightTopping = double.Parse(inputTopping[2]);

                    Topping topping = new Topping(toppingType, weightTopping);
                    //Console.WriteLine($"{topping.GetTotalCalories():f2}");
                    pizza.AddTopping(topping);
                    command = Console.ReadLine();
                }
                Console.WriteLine($"{pizzaName} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
