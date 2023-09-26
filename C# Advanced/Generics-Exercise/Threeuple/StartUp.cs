
namespace Threeuple
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputPerson = Console.ReadLine().Split();
            string fullName = inputPerson[0] + " " + inputPerson[1];
            string address = inputPerson[2];
            string town = string.Join(" ", inputPerson.Skip(3));

            string[] inputBeer = Console.ReadLine().Split();
            string name = inputBeer[0];
            int beerLiters = int.Parse(inputBeer[1]);
            string drunkOrNot = inputBeer[2];
            bool IsDrunk = drunkOrNot == "drunk" ? true : false;
            
            string[] bankAccount = Console.ReadLine().Split();
            string nameAccount = bankAccount[0];
            double balance = double.Parse(bankAccount[1]);
            string nameBank = bankAccount[2];

            var person = new Threeuple<string, string, string>(fullName, address, town);
            var beer = new Threeuple<string, int, bool>(name, beerLiters, IsDrunk);
            var bankDetails = new Threeuple<string, double, string>(nameAccount, balance, nameBank);

            Console.WriteLine(person);
            Console.WriteLine(beer);
            Console.WriteLine(bankDetails);
        }
    }
}
