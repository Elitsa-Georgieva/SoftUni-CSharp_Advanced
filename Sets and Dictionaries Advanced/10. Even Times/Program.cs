using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints a number from a collection, which appears an even number of times in it

            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            FillDictionary(n, numbers);

            PrintResult(numbers);
        }

        static void PrintResult(Dictionary<int, int> numbers)
        {
            int num = 0;

            foreach (KeyValuePair<int, int> kvp in numbers)
            {
                if (kvp.Value % 2 == 0)
                {
                    num = kvp.Key;
                }
            }

            Console.WriteLine(num);
        }

        static Dictionary<int, int> FillDictionary(int n, Dictionary<int, int> numbers)
        {
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                //only one of them appears an even number of times
                if (numbers.ContainsKey(number) == false)
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            return numbers;
        }
    }
}
