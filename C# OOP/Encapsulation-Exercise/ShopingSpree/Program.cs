using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> people = Console.ReadLine().
                Split(';', StringSplitOptions.RemoveEmptyEntries)
                .Select(p => new
                {
                    Name = p.Split('=', StringSplitOptions.RemoveEmptyEntries)[0],
                    Money = decimal.Parse(p.Split('=', StringSplitOptions.RemoveEmptyEntries)[1])
                })
                .Select(x => new Person(x.Name, x.Money))
                .ToList();

                List<Product> products = Console.ReadLine().
                    Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => new
                    {
                        Name = p.Split('=', StringSplitOptions.RemoveEmptyEntries)[0],
                        Cost = decimal.Parse(p.Split('=', StringSplitOptions.RemoveEmptyEntries)[1])
                    })
                    .Select(x => new Product(x.Name, x.Cost))
                    .ToList();


                string input = Console.ReadLine();

                while (input != "END")
                {
                    string[] arguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string name = arguments[0];
                    string product = arguments[1];

                    Person person = people.FirstOrDefault(x => x.Name == name);
                    Product product1 = products.FirstOrDefault(y => y.Name == product);
                    person.AddToBag(product1);

                    input = Console.ReadLine();
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
