namespace WildFarm.Factories
{
    using System;
    using Models.Foods;
    public class FoodFactory
    {
        public static Food CreateFood(string[] foodArgs)
        {
            string foodType = foodArgs[0].ToLower();
            int quantity = int.Parse(foodArgs[1]);

            switch (foodType)
            {
                case "fruit":
                    return new Fruit(quantity);
                case "meat":
                    return new Meat(quantity);
                case "seeds":
                    return new Seeds(quantity);
                case "vegetable":
                    return new Vegetable(quantity);
                default:
                    throw new ArgumentException("Invalid food type!");
            }
        }
    }
}