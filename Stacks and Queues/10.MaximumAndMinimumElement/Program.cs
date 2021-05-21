using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfQueries = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < numOfQueries; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string querie = parts[0];

                if (querie == "1")
                {
                    int numToPush = int.Parse(parts[1]);
                    numbers.Push(numToPush);
                }
                else if (querie == "2")
                {
                    if (numbers.Count > 0)
                    {
                        numbers.Pop();
                    }
                    
                }
                else if (querie == "3")
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine($"{numbers.Max()}");
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (querie == "4")
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine($"{numbers.Min()}");
                    }
                    else
                    {
                        continue;
                    }
                    
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
