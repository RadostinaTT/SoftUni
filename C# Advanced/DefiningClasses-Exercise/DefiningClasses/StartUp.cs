using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            Person[] people = new Person[counter];

            for (int i = 0; i < counter; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                var name = input[0];
                var age = int.Parse(input[1]);
                people[i] = new Person(name, age);

            }
            List<Person> result = people.OrderBy(x => x.Name).Where(y => y.Age > 30).ToList();

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
