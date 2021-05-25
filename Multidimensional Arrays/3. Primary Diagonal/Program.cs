using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSizes = int.Parse(Console.ReadLine());

            int[,] matrix = new int[squareMatrixSizes, squareMatrixSizes];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowValues[j];
                }

                
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int PrimaryDiagonalSum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    PrimaryDiagonalSum += matrix[i, j];
                    j++;
                }

                Console.WriteLine(PrimaryDiagonalSum);
            }
        }
    }
}
