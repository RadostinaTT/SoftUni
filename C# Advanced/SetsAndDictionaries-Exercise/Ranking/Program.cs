using System;
using System.Linq;
using System.Collections.Generic;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, string> passwords = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of contests")
                {
                    break;
                }
                var parts = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                var contest = parts[0];
                var password = parts[1];
                passwords.Add(contest, password);
            }

            while (true)
            {
                var studentsResults = Console.ReadLine();
                if (studentsResults == "end of submissions")
                {
                    break;
                }
                var parts = studentsResults.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                var contest = parts[0];
                var password = parts[1];
                var studentName = parts[2];
                var points = int.Parse(parts[3]);

                if (passwords.ContainsKey(contest))
                {
                    if (passwords[contest].Equals(password))
                    {
                        if (!candidates.ContainsKey(studentName))
                        {
                            candidates.Add(studentName, new Dictionary<string, int>());
                        }
                        if (!candidates[studentName].ContainsKey(contest))
                        {
                            candidates[studentName].Add(contest, points);
                        }
                        else
                        {
                            if (candidates[studentName][contest] < points)
                            {
                                candidates[studentName][contest] = points;
                            }
                        }
                    }
                }
            }

            var winner = candidates.OrderByDescending(x => x.Value.Values.Sum()).FirstOrDefault();
            Console.WriteLine($"Best candidate is {winner.Key} with total {winner.Value.Values.Sum()} points.");
            Console.WriteLine("Ranking:");

            foreach (var student in candidates.OrderBy(n => n.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var contest in student.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
