using System;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, string, bool> startWithFunc = (x, y) => x.StartsWith(y);
            Func<string, string, bool> endWithFunc = (x, y) => x.EndsWith(y);
            Func<string, int, bool> checkLenght = (x, y) => x.Length == y;

            Func<List<string>, List<string>, List<string>> doublePeople = (x, y) =>
            {
                foreach (string nameToDouble in y)
                {
                    for (int i = 0; i < x.Count * 2; i++)
                    {
                        if (i < x.Count)
                        {
                            if (x[i] == nameToDouble)
                            {
                                x.Insert(i, nameToDouble);
                                i++;
                            }
                        }
                    }
                }
                return x;
            };
            List<string> filteredGuests = new List<string>();

            while (true)
            {
                var commandString = Console.ReadLine();
                if (commandString == "Party!")
                {
                    break;
                }

                var parts = commandString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = parts[0];
                var criteria = parts[1];
                var parameter = parts[2];

                switch (criteria)
                {
                    case "StartsWith":
                        filteredGuests = guests.Where(s => startWithFunc(s, parameter))
                            .Distinct()
                            .ToList();
                        break;
                    case "EndsWith":
                        filteredGuests = guests.Where(s => endWithFunc(s, parameter))
                            .Distinct()
                            .ToList();
                        break;
                    case "Length":
                        filteredGuests = guests.Where(s => checkLenght(s, int.Parse(parameter)))
                            .Distinct()
                            .ToList();
                        break;
                }

                switch (command)
                {
                    case "Remove":
                        guests = guests.Where(x => !filteredGuests.Contains(x)).ToList();
                        break;
                    case "Double":
                        guests = doublePeople(guests, filteredGuests);
                        break;
                }

            }
            if (guests.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
