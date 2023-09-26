using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var readWordsToSearch = File.ReadAllLines(@"Resources/words.txt");
            var readText = File.ReadAllText(@"Resources/text.txt");
            var resultDict = new Dictionary<string, int>();
            var results = new string[readWordsToSearch.Length];
            var textToWords = readText.Split(new char[] { ' ', '-', '.', '?', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < readWordsToSearch.Length; i++)
            {
                var currentSearch = readWordsToSearch[i];
                var countFound = 0;
                for (int j = 0; j < textToWords.Length; j++)
                {
                    if (currentSearch.ToLower() == textToWords[j].ToLower())
                    {
                        countFound++;
                    }
                }
                results[i] = currentSearch + " - " + countFound;
                resultDict.Add(currentSearch, countFound);
            }
            File.WriteAllLines(@"actualResult.txt", results);
            var sortedResultDict = resultDict.OrderByDescending(x => x.Value);
            var sortedResultString = new string[readWordsToSearch.Length];
            var counter = 0;
            foreach (var word in sortedResultDict)
            {
                sortedResultString[counter] = word.Key + " - " + word.Value;
                counter++;
            }
            File.WriteAllLines(@"expectedResult.txt", sortedResultString);
        }
    }
}
