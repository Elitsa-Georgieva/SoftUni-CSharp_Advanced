using System;
using System.Collections.Generic;

namespace _6.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            

            while (true)
            {
                int namesCount = names.Count;

                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine($"{names.Count} people remaining.");
                    break;
                }
                
                if (input == "Paid")
                {
                    for (int i = 0; i < namesCount; i++)
                    {
                        Console.WriteLine(names.Dequeue());
                    }

                    //names.Clear();
                }
                else
                {
                    names.Enqueue(input);
                }

            }
        }
    }
}
