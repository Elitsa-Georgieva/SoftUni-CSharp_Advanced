using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] kids = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Queue<string> kidsNames = new Queue<string>(kids);

            while (kidsNames.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    kidsNames.Enqueue(kidsNames.Dequeue());
                }

                Console.WriteLine($"Removed {kidsNames.Dequeue()}");
            }

            Console.WriteLine($"Last is {kidsNames.Dequeue()}");
        }
    }
}
