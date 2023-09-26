using System;
using System.IO;
using System.Linq;
using System.Text;

namespace StreamsFilesAndDirectories_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            var specialSymbols = new[] { "-", ",", ".", "!", "?" };

            using (var streamReader = new StreamReader(@"text.txt"))
            using (var streamWriter = new StreamWriter(@"task2-output.txt"))
            {
                while (!streamReader.EndOfStream)
                {
                    var readLine = streamReader.ReadLine();
                    if (counter % 2 == 0)
                    {
                        var words = readLine.Split(" ");
                        for (int i = 0; i < words.Length; i++)
                        {
                            var currentWord = words[i];
                            foreach (var symbol in specialSymbols)
                            {
                                currentWord = currentWord.Replace(symbol, "@");
                            }
                            words[i] = currentWord;
                        }
                        var result = string.Join(" ", words.Reverse());
                        streamWriter.WriteLine(result.TrimEnd(), true);
                    }
                    counter++;
                }
            }
            
        }
    }
}
