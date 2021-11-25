using System;
using System.IO;

namespace Ülesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string directorypath = @$"C:\users\opilane\samples\Test";
            string starsfile = "stars.txt";
            string planetfile = "planets.txt";

            string starsfullpath = $@"{directorypath}\{starsfile}";
            string planetfullpath = $@"{directorypath}\{planetfile}";

            
            bool starsfullpathexists = File.Exists(starsfullpath);
            bool planetsfullpathexists = File.Exists(planetfullpath);

            if (!planetsfullpathexists)
            {
                Console.WriteLine($"File {planetfile} doest exist so i will create if for you");
                File.Create(planetfullpath);
            }
            else if (!starsfullpathexists)
            {
                Console.WriteLine($"File {starsfile} doesnt exist so i will create it for you");
                File.Create(starsfullpath);
            }
            else
            {
                Console.WriteLine("Files already exist");
            }
        }
    }
}
