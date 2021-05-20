using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int totalCarsPassed = 0;
            Queue<string> cars = new Queue<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command != "end" && command != "green")
                {
                    cars.Enqueue(command);
                }

                if (command == "end")
                {
                    Console.WriteLine($"{totalCarsPassed} cars passed the crossroads");
                    break;
                }

                if (command == "green")
                {
                    
                    for (int i = 0; i < N; i++)
                    { 
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            totalCarsPassed += 1;
                        }
                            
                    }
                    
                }
                //else
                //{
                //    cars.Enqueue(command);
                //    Console.WriteLine($"{command} passed!");
                //}
            }
        }
    }
}
