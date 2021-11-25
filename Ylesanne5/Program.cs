using System;
using System.IO;

namespace Ylesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Facts So Interesting You'll Say, OMG!");
            string rootdirectory = $@"C:\Users\opilane\samples\Test\";
            string fileName = "FunFacts.txt";
            string fullPath = $@"{rootdirectory}\{fileName}";

            string[] datafromfile = File.ReadAllLines(fullPath);
            Random rnd = new Random();
            Console.WriteLine(datafromfile[rnd.Next(datafromfile.Length)]);

        }
    }
}
