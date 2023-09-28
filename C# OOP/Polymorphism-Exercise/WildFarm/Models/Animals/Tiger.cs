namespace WildFarm.Models.Animals
{
    using System;
    using Models.Foods;
    public class Tiger : Feline
    {
        private const double TigerWeight = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightMiultiplier => TigerWeight;

        public override void ProduceSound()
        {
            System.Console.WriteLine("ROAR!!!");
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