using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            //Console.WriteLine(input.Min());

            Func<int[], int> minNumber = n => n.Min();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(minNumber(numbers));

            //int number = Console.ReadLine().Split().Select(int.Parse).Min();
            //Console.WriteLine(number);
        }

    }
}
