using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, string, bool> startWithFunc = (x, y) => x.StartsWith(y);
            Func<string, string, bool> endWithFunc = (x, y) => x.EndsWith(y);
            Func<string, int, bool> checkLenght = (x, y) => x.Length == y;
            Func<string, string, bool> checkContains = (x, y) => x.Contains(y);

            List<string> filteredGuests = new List<string>();
            List<string> result = new List<string>(guests);

            while (true)
            {
                var commandString = Console.ReadLine();
                if (commandString == "Print")
                {
                    break;
                }

                var parts = commandString.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var command = parts[0];
                var criteria = parts[1];
                var parameter = parts[2];

                switch (criteria)
                { 
                    case "Starts with":
                        filteredGuests = guests.Where(s => startWithFunc(s, parameter))
                            .Distinct()
                            .ToList();
                        break;
                    case "Ends with":
                        filteredGuests = guests.Where(s => endWithFunc(s, parameter))
                            .Distinct()
                            .ToList();
                        break;
                    case "Length":
                        filteredGuests = guests.Where(s => checkLenght(s, int.Parse(parameter)))
                            .Distinct()
                            .ToList();
                        break;
                    case "Contains":
                        filteredGuests = guests.Where(s => checkContains(s, parameter))
                            .Distinct()
                            .ToList();
                        break;
                }

                switch (command)
                {
                    case "Add filter":
                        result.RemoveAll(x => filteredGuests.Contains(x));
                        
                        break;
                    case "Remove filter":
                        
                        result.AddRange(filteredGuests);
                        break;
                }
                
            }
            guests.RemoveAll(i => !result.Contains(i));
            if (guests.Count > 0)
            {
                Console.WriteLine($"{string.Join(" ", guests)}");
            }
            
        }
    }
}
