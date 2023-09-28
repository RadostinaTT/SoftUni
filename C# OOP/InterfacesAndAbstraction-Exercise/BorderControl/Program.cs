namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            List<IBuyer> collection = new List<IBuyer>();

            int  countPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < countPeople; i++)
            {
                string[] inputInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (inputInfo.Length == 4)
                {
                    string name = inputInfo[0];
                    int age = int.Parse(inputInfo[1]);
                    string id = inputInfo[2];
                    string birthday = inputInfo[3];
                    Citizen citizen = new Citizen(id, name, age, birthday);
                    collection.Add(citizen);
                }
                else if (inputInfo.Length == 3)
                {
                    string name = inputInfo[0];
                    int age = int.Parse(inputInfo[1]);
                    string group = inputInfo[2];
                    Rebel rebel = new Rebel(name, age, group);
                    collection.Add(rebel);
                }

                
            }
            string nameToBuy = Console.ReadLine();
            while (nameToBuy != "End")
            {
                if (collection.Any(x => x.Name == nameToBuy))
                {
                    collection.FirstOrDefault(x => x.Name == nameToBuy).BuyFood();
                }
                nameToBuy = Console.ReadLine();
            }
            
            Console.WriteLine(collection.Sum(x => x.Food));
        }
    }
}