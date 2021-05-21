using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Queue<int[]> petrolPumpInfo = new Queue<int[]>();

            for (int i = 0; i < N; i++)
            {
                int[] amountAndDistance = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                petrolPumpInfo.Enqueue(amountAndDistance);
            }

            int idx = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (var amountAndDistance in petrolPumpInfo)
                {
                    int petrolAmount = amountAndDistance[0];
                    int distance = amountAndDistance[1];

                    totalFuel += petrolAmount - distance;

                    if (totalFuel < 0)
                    {
                        petrolPumpInfo.Enqueue(petrolPumpInfo.Dequeue());
                        idx++;
                        break;
                    }
                }

                if (totalFuel > 0)
                {
                    break;
                }

            }
            Console.WriteLine(idx);

        }
    }
}
