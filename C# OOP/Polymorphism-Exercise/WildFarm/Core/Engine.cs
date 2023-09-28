namespace WildFarm.Core
{
    using System;
    using System.Collections.Generic;
    using Factories;
    using Models.Animals;
    using Models.Foods;

    public class Engine
    {
        public void Run()
        {
            List<Animal> animals = new List<Animal>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                Animal animal = AnimalFactory.CreateAnimal(command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries));
                animals.Add(animal);
                animal.ProduceSound();
                Food food = FoodFactory.CreateFood(Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries));
                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                command = Console.ReadLine();
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}