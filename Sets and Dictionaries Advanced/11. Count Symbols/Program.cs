using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine()
                .ToCharArray();

            SortedDictionary<char, int> symbolsBycount = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (symbolsBycount.ContainsKey(symbol) == false)
                {
                    symbolsBycount.Add(symbol, 1);
                }
                else
                {
                    symbolsBycount[symbol]++;
                }

                
            }

            
            foreach (var kvp in symbolsBycount)
            {
                //S: 1 time/s
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
