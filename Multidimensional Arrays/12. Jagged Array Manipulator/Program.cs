using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[numberOfRows][];


            //filling jagged array
            for (int i = 0; i < jagged.Length; i++)
            {
                int[] inputNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagged[i] = new double[inputNumbers.Length];

                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = inputNumbers[j];
                }
            }

            //analyzing jagged

            for (int j = 0; j < jagged.Length - 1; j++)
            {
                if (jagged[j].Length == jagged[j + 1].Length)
                {
                    jagged[j] = Multiplier(jagged[j]);
                    jagged[j + 1] = Multiplier(jagged[j + 1]);
                    
                }

                
                else if (jagged[j].Length != jagged[j + 1].Length)
                {
                    jagged[j] = Divider(jagged[j]);
                    jagged[j + 1] = Divider(jagged[j + 1]);

                }

                
            }

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ");

                string command = tokens[0].ToUpper();

                if (command == "END")
                {
                    foreach (double[] r in jagged)
                    {
                        Console.WriteLine(string.Join(" ", r));
                    }
                    break;
                }

                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (command == "ADD")
                {
                    if (row >= 0 && col >= 0 && row < jagged.Length && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "SUBTRACT")
                {
                    if (row >= 0 && col >= 0 && row < jagged.Length && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        static double[] Multiplier(double[] array) =>

            array = array

                .Select(x => x * 2)

                .ToArray();



        static double[] Divider(double[] array) =>

            array = array

                .Select(x => x / 2)

                .ToArray();


    }
}
