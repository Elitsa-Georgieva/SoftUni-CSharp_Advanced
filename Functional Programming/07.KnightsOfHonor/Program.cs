using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList().ForEach(name =>Console.WriteLine("Sir " + name));
        }
    }
}
