namespace WildFarm.Models.Animals
{
    using System;
    using Models.Foods;

    public class Dog : Mammal
    {
        private const double DogWeight = 0.40;
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightMiultiplier => DogWeight;

        public override void ProduceSound()
        {
            System.Console.WriteLine("Woof!");
        }
        protected override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;

            if (type != nameof(Meat))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}