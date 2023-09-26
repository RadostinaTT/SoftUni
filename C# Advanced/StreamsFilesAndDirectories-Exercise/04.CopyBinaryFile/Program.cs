using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new FileStream(@"Resources/copyMe.png", FileMode.Open, FileAccess.Read))
            using (var writer = new FileStream(@"copied.png", FileMode.Create, FileAccess.Write))
            {
                var buffer = new byte[4096];
                var length = 0;

                while ((length = reader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    writer.Write(buffer, 0, length);
                }
                
            }
        }
    }
}
