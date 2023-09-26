using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputPerson = Console.ReadLine().Split();
            string fullName = inputPerson[0] + " " + inputPerson[1];
            string town = inputPerson[2];

            string[] inputBeer = Console.ReadLine().Split();
            string name = inputBeer[0];
            int beerLiters = int.Parse(inputBeer[1]);

            string[] inputIntDouble = Console.ReadLine().Split();
            int numberInt = int.Parse(inputIntDouble[0]);
            double numberDouble = double.Parse(inputIntDouble[1]);

            var person = new Tuple<string, string>(fullName, town);
            var beer = new Tuple<string, int>(name, beerLiters);
            var intDouble = new Tuple<int, double>(numberInt, numberDouble);

            Console.WriteLine(person);
            Console.WriteLine(beer);
            Console.WriteLine(intDouble);
        }
    }
}
