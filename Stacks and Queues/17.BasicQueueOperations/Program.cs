using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NSX = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>();

            int N = NSX[0];
            int S = NSX[1];
            int X = NSX[2];

            for (int i = 0; i < N; i++)
            {
                numbers.Enqueue(nums[i]);
            }

            for (int i = 0; i < S; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Any())
            {
                if (numbers.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine($"{numbers.Min()}");
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
