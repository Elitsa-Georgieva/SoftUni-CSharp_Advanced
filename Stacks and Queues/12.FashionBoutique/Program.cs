using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capacityOfRack = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(clothesInBox);

            int sumOfClothes = 0;
            int countOfRacks = 0;

            while (true)
            {
                if (clothes.Count > 0)
                {
                    int currentCloths = clothes.Pop();
                    sumOfClothes += currentCloths;

                    if (sumOfClothes == capacityOfRack)
                    {
                        countOfRacks++;
                        sumOfClothes = 0;
                    }
                    //If it becomes greater than the capacity, don't add the piece of
                    //clothing to the current rack and take a new one. 
                    else if (sumOfClothes > capacityOfRack)
                    {
                        clothes.Push(currentCloths);
                        countOfRacks++;
                        sumOfClothes = 0;
                        
                    }
                    
                }
                else
                {
                    if (sumOfClothes > 0)
                    {
                        countOfRacks++;
                    }
                    break;
                }
                
            }

            Console.WriteLine($"{countOfRacks}");
        }
    }
}
