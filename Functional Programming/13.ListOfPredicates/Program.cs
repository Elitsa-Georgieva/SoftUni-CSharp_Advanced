using System;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Func<int[], int, bool> filter = (allDividers, number) =>
             
            {
                ////bool divisible = true;

                ////for (int i = 0; i < allDividers.Length; i++)
                ////{
                ////    if (number % allDividers[i] != 0)
                ////    {
                ////        divisible = false;
                ////        break;
                ////    }
                ////}

                //return divisible;

                return allDividers.All(t => number % t == 0);
            };

            int[] divisibleNums = Enumerable.Range(1, N)
                .Where(number => filter(dividers, number))
                .ToArray();

            Console.WriteLine(string.Join(" ", divisibleNums));

        }
    }
}
