using System;
using System.IO;
using System.Collections.Generic;

namespace Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = $@"C:\Users\opilane\Samples\Test";
            Console.WriteLine("kas soovite näha stars või planets faili sisu?");
            string userFile = Console.ReadLine();
            string FileDirectory = $@"{rootdirectory}\{userFile}.txt";
            bool exists = File.Exists(FileDirectory);

            if (exists)
            {
                string[] datafromfile = File.ReadAllLines(FileDirectory);
                if (userFile == "planets" || userFile == "stars")
                {
                    foreach (string Line in datafromfile)
                    {
                        Console.WriteLine(Line);
                    }
                }
                else
                {
                    Console.WriteLine($"{userFile}.txt does not exist");
                }


            }
            else
            {
                Console.WriteLine($"{userFile}.txt does not exist");
            }
        }
    }
}
