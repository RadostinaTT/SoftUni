using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var filesByExtension = new Dictionary<string, Dictionary<string, long>>();
            DirectoryInfo dirInfo = new DirectoryInfo(Environment.CurrentDirectory);
            var files = dirInfo.GetFiles();

            foreach (var file in files)
            {
                var extension = file.Extension;

                if (!filesByExtension.ContainsKey(extension))
                {
                    filesByExtension.Add(extension, new Dictionary<string, long>());
                }
                filesByExtension[extension].Add(file.Name, file.Length);
            }

            var sortedFilesByExtension = filesByExtension.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key);

            using(var streamWriter = new StreamWriter(@"../../../report.txt"))
            {
                foreach (var extension in sortedFilesByExtension)
                {
                    streamWriter.WriteLine(extension.Key);

                    var currentFile = extension.Value.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                    foreach (var file in currentFile)
                    {
                        streamWriter.WriteLine($"--{file.Key} - {(file.Value/ 1000.0):f3}kb");
                    }
                }
            }

            
        }
    }
}
