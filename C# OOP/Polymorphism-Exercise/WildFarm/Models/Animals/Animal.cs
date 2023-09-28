namespace WildFarm.Models.Animals
{
    using Models.Foods;

    public abstract class Animal
    {
        private string name;
        private double weight;
        private int foodEaten;

        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            private set { weight = value; }
        }

        public int FoodEaten
        {
            get { return foodEaten; }
            set { foodEaten = value; }
        }

        protected abstract double WeightMiultiplier { get; }

        public abstract void ProduceSound();

        protected abstract void ValidateFood(Food food);
        public virtual void Eat(Food food)
        {
            ValidateFood(food);
            this.Weight += this.WeightMiultiplier * food.Quantity;
            this.FoodEaten += food.Quantity;
        }
    }
}