using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wordrop = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];

                string[] clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                

                if (wordrop.ContainsKey(color) == false)
                {
                    wordrop.Add(color, new Dictionary<string, int>());
                    
                }

                for (int cloth = 0; cloth < clothes.Length; cloth++)
                {
                    if (wordrop[color].ContainsKey(clothes[cloth]) == false)
                    {
                        wordrop[color].Add(clothes[cloth], 0);
                    }

                    wordrop[color][clothes[cloth]]++;
                }


            }

            string[] clothesToFind = Console.ReadLine()
                .Split();

            string colorToFind = clothesToFind[0];
            string clothToFind = clothesToFind[1];

            foreach (var kvp in wordrop)
            {
                //"{color} clothes:
                Console.WriteLine($"{kvp.Key} clothes:");

                //* {item1} - {count}

                foreach (KeyValuePair<string, int> cloth in kvp.Value)
                {
                    if (colorToFind == kvp.Key && clothToFind == cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                        //continue;
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }

                    
                }
            }
        }
    }
}
