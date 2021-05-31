using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[] filledBottles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Stack<int> bottles = new Stack<int>(cupsCapacity);
            Queue<int> cups = new Queue<int>(filledBottles);

            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currBottle = bottles.Pop();
                    if (currBottle < cups.Peek())
                    {
                        int currCup = cups.Dequeue();
                        currCup -= currBottle;
                        while (true)
                        {
                            int newBottle = bottles.Pop();
                            if (newBottle > currCup)
                            {
                                currCup -= newBottle;
                            }
                            else
                            {
                                wastedWater += newBottle - currCup;
                                break;
                            }

                            if (bottles.Count == 0)
                            {
                                Console.WriteLine($"Cups: {currCup + " " + string.Join(" ", cups)}");
                                Console.WriteLine("Wasted litters of water: " + wastedWater);
                                return;
                            }
                        }
                    }
                    else if (currBottle >= cups.Peek())
                    {
                        wastedWater += currBottle - cups.Peek();
                        cups.Dequeue();
                    }

                    if (cups.Count == 0)
                    {
                        Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                        Console.WriteLine("Wasted litters of water: " + wastedWater);
                        return;
                    }
                    else if (bottles.Count == 0)
                    {
                        Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                        Console.WriteLine("Wasted litters of water: " + wastedWater);
                        return;
                    }


            }
        }
    }
}
