using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterRows = 1;
            var readLine = File.ReadAllLines(@"Resources/text.txt");
            
            for (int i = 0; i < readLine.Length; i++)
            {
                var line = readLine[i];
                int countLetters = 0;
                int countPunctuations = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    var currentChar = line[j];
                    if (Char.IsLetter(currentChar))
                    {
                        countLetters++;
                    }
                    else if (Char.IsPunctuation(currentChar))
                    {
                        countPunctuations++;
                    }
                        
                }
                var result = string.Join("", $"Line{counterRows}: ", line, $" ({countLetters})", $"({countPunctuations})");

                readLine[i] = result;    
                counterRows++;
            }
            File.WriteAllLines(@"task2-output.txt", readLine);
            
        }
    }
}
