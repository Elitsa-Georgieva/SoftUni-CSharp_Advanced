using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string snake = Console.ReadLine();

            Queue<char> queueSnake = new Queue<char>(snake.ToArray());

            char[,] matrix = new char[rows, cols];


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i % 2 == 0)
                    {
                        char currSymbol = RollTheSnake(queueSnake);
                        matrix[i, j] = currSymbol;
                    }
                    else if (i % 2 != 0)
                    {
                        for (int k = cols - 1; k >= 0; k--)
                        {
                            char currSymbol = RollTheSnake(queueSnake);
                            matrix[i, k] = currSymbol;
                        }

                        break;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static char RollTheSnake(Queue<char> queueSnake)
        {
            char currSymbol = queueSnake.Dequeue();
            queueSnake.Enqueue(currSymbol);
            return currSymbol;
        }
    }
}
