namespace WildFarm.Factories
{
    using System;
    using Models.Animals;

    public class AnimalFactory
    {
        public static Animal CreateAnimal(string[] argsAnimal)
        {
            string typeAnimal = argsAnimal[0].ToLower();

            switch (typeAnimal)
            {
                case "cat":
                    return new Cat(argsAnimal[1], double.Parse(argsAnimal[2]), argsAnimal[3], argsAnimal[4]);
                case "tiger":
                    return new Tiger(argsAnimal[1], double.Parse(argsAnimal[2]), argsAnimal[3], argsAnimal[4]);
                case "hen":
                    return new Hen(argsAnimal[1], double.Parse(argsAnimal[2]), double.Parse(argsAnimal[3]));
                case "owl":
                    return new Owl(argsAnimal[1], double.Parse(argsAnimal[2]), double.Parse(argsAnimal[3]));
                case "mouse":
                    return new Mouse(argsAnimal[1], double.Parse(argsAnimal[2]), argsAnimal[3]);
                case "dog":
                    return new Dog(argsAnimal[1], double.Parse(argsAnimal[2]), argsAnimal[3]);
                default:
                    throw new ArgumentException($"{typeAnimal} is not a valid Animal type.");
            }
        }
    }
}