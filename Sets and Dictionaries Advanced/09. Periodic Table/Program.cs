using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> uniqueChemicalCompounds = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] chemicalCompounds = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string compound in chemicalCompounds)
                {
                    uniqueChemicalCompounds.Add(compound);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueChemicalCompounds));
        }
    }
}
