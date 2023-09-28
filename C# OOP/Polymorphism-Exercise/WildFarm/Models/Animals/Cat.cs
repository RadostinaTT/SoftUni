namespace WildFarm.Models.Animals
{
    using System;
    using Models.Foods;

    public class Cat : Feline
    {
        private const double CatWeight = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightMiultiplier => CatWeight;

        public override void ProduceSound()
        {
            System.Console.WriteLine("Meow");
        }
        protected override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;

            if (type != nameof(Vegetable) && type != nameof(Meat))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}