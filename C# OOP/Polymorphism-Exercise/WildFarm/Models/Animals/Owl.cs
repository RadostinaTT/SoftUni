namespace WildFarm.Models.Animals
{
    using System;
    using Models.Foods;

    public class Owl : Bird
    {
        private const double OwlWeight = 0.25;
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightMiultiplier => OwlWeight;

        public override void ProduceSound()
        {
            System.Console.WriteLine("Hoot Hoot");
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