using System;

namespace ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while (input != "End")
            {
                string[] inputInfo = input
                    .Split();
                string name = inputInfo[0];
                string country = inputInfo[1];
                int age = int.Parse(inputInfo[2]);

                IPerson citizen1 = new Citizen(name, age, country); 
                IResident citizen = new Citizen(name, age, country);
                
                Console.WriteLine(citizen1.GetName());
                Console.WriteLine(citizen.GetName());
                input = Console.ReadLine();
            }
        }
    }
}
