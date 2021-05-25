using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = ReadMatrix(rows, cols);

            int bestSum = 0;
            int bestRowIdx = 0;
            int bestColIdx = 0;


            for (int i = 0; i < rows - 2; i++)
            {
                //1 5 5 2 4
                //2 1 4 14 3
                //3 7 11 2 8
                //4 8 12 16 4

                for (int j = 0; j < cols - 2; j++)
                {
                    int firstRowSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2];
                    int secondRowSum = matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2];
                    int thirdRowSum = matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    int currSum = firstRowSum + secondRowSum + thirdRowSum;
                    
                    if (currSum > bestSum)
                    {
                        bestSum = currSum;
                        bestRowIdx = i;
                        bestColIdx = j;
                    }
                }
            }


            Console.WriteLine($"Sum = {bestSum}");

            for (int i = bestRowIdx; i <= bestRowIdx + 2; i++)
            {
                for (int j = bestColIdx; j <= bestColIdx + 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");

                }

                Console.WriteLine();
            }
        }

        private static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowValues[j];
                }
            }

            return matrix;
        }
    }
}
