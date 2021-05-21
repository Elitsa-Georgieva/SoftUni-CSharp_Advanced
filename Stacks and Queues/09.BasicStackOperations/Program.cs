using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01.BasicStackOperations
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

            Stack<int> numbers = new Stack<int>();

            int N = NSX[0];
            int S = NSX[1];
            int X = NSX[2];

            for (int i = 0; i < N; i++)
            {
                numbers.Push(nums[i]);
            }

            for (int i = 0; i < S; i++)
            {
                numbers.Pop();
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
