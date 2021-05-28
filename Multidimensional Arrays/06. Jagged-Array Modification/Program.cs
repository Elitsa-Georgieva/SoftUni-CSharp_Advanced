using System;
using System.Linq;
using System.Numerics;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int i = 0; i < jagged.Length; i++)
            {
                string[] colElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                jagged[i] = new int[colElements.Length];

                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = int.Parse(colElements[j]);
                }

            }

            while (true)
            {
                string[] parts = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0].ToUpper();
                
                if (command == "END")
                {
                    foreach (var element in jagged)
                    {
                        Console.WriteLine(string.Join(" ", element));
                    }
                    break;
                }

                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);

                if (row < 0 || row > jagged.Length - 1 || col < 0 || col > jagged[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (command == "ADD")
                {
                    jagged[row][col] += value;
                    
                }
                else if (command == "SUBTRACT")
                {
                    jagged[row][col] -= value;
                }

            }
        }
    }
}
