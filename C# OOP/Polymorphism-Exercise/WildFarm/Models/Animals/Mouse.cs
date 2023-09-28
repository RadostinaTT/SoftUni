namespace WildFarm.Models.Animals
{
    using System;
    using Models.Foods;

    public class Mouse : Mammal
    {
        private const double MouseWeight = 0.10;
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightMiultiplier => MouseWeight;

        public override void ProduceSound()
        {
            System.Console.WriteLine("Squeak");
        }
        protected override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;

            if (type != nameof(Vegetable) && type != nameof(Fruit))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}