using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setsLengths = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int nL = setsLengths[0];
            int mL = setsLengths[1];

            HashSet<int> n = new HashSet<int>();
            HashSet<int> m = new HashSet<int>();

            FillTheSet(n, nL);
            FillTheSet(m, mL);
            CheckSets(n, m);

        }

        static void CheckSets(HashSet<int> first, HashSet<int> second)
        {
            List<int> ourUniqueNums = new List<int>();

            foreach (int number in first)
            {
                if (second.Contains(number))
                {
                    ourUniqueNums.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", ourUniqueNums));
        }

        static HashSet<int> FillTheSet(HashSet<int> hashSet, int Lenght)
        {
            for (int i = 0; i < Lenght; i++)
            {
                hashSet.Add(int.Parse(Console.ReadLine()));
            }

            return hashSet;
        }
    }
}
