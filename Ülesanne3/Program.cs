using System;
using System.IO;
using System.Collections.Generic;

namespace Ülesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string StarsPath = @"\Users\opilane\Samples\Test\stars.txt";
            string PlanetsPath = @"\Users\opilane\Samples\Test\planets.txt";
            string MilkyWayPath = @"\Users\opilane\Samples\Test\MilkyWay.txt";

            List<string> stars = new List<string>();
            List<string> planets = new List<string>();

            string[] sourceData = File.ReadAllLines(MilkyWayPath);

            foreach(string element in sourceData)
            {
                if (element.Contains("star"))
                {
                    stars.Add(element);
                }
                if (element.Contains("planet"))
                {
                    planets.Add(element);
                }
            }
            File.WriteAllLines(StarsPath, stars);
            File.WriteAllLines(PlanetsPath, planets);

        }
    }
}
