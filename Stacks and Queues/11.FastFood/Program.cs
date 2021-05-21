using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] sequenceOfOrders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(sequenceOfOrders);

            if (orders.Any())
            {
                Console.WriteLine($"{orders.Max()}");
            }

            int sum = 0;
            //Before each order, check if you have enough food left to complete it.
            //If you have, remove the order from the queue and reduce the amount of food you have. 

            while (orders.Count > 0)
            {
                int firstInLine = orders.Peek();
                sum += firstInLine;
                if (sum <= quantityOfFood)
                {
                    orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }
            }

            Console.WriteLine($"Orders complete");


            //for (int i = 0; i < sequenceOfOrders.Length; i++)
            //{
            //    int currentOrder = sequenceOfOrders[i];
            //    if (currentOrder <= quantityOfFood)
            //    {
            //        quantityOfFood -= orders.Dequeue();
            //    }
            //}

            //if (orders.Count == 0)
            //{
            //    Console.WriteLine($"Orders complete");
            //}
            //else
            //{
            //    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            //}
        }
    }
}
