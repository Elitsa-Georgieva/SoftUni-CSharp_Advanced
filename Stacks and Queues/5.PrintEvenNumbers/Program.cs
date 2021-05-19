using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(array);
            Queue<int> evenNums = new Queue<int>();

            while (numbers.Count > 0)
            {
                
                if (numbers.Peek() % 2 == 1)
                {
                    numbers.Dequeue();
                }
                else
                {
                    evenNums.Enqueue(numbers.Dequeue());
                }

            }

            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}
