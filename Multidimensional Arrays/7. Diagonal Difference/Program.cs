using System;
using System.Globalization;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfSquareMatrix = int.Parse(Console.ReadLine());

            int[,] matrixSquare = new int[sizeOfSquareMatrix, sizeOfSquareMatrix];

            for (int i = 0; i < matrixSquare.GetLength(0); i++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrixSquare.GetLength(1); j++)
                {
                    matrixSquare[i, j] = rowValues[j];
                }
            }

            int primaryD = 0;
            int secondaryD = 0;

            int n = matrixSquare.GetLength(0);

            for (int i = 0; i < matrixSquare.GetLength(0); i++)
            {
                primaryD += matrixSquare[i, i];
                secondaryD += matrixSquare[i, n - i - 1];

            }

            

            Console.WriteLine(Math.Abs(primaryD - secondaryD));
        }
    }
}
