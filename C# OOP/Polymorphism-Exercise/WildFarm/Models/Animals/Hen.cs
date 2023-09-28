namespace WildFarm.Models.Animals
{
    using System;
    using Models.Foods;

    public class Hen : Bird
    {
        private const double HenWeight = 0.35;
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightMiultiplier => HenWeight;

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }

        protected override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;

            if (type != nameof(Vegetable) && type != nameof(Meat) &&
                type != nameof(Fruit) && type != nameof(Seeds))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}