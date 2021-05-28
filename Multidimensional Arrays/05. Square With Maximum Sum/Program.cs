using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizesOfMatrix = ArrayReadFromConsole();

            int[,] matrix = new int[sizesOfMatrix[0], sizesOfMatrix[1]];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] colArr = ArrayReadFromConsole();


                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = colArr[j];
                }

            }

            int biggestSum = int.MinValue;
            int biggestRow = 0;
            int biggestCol = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int newSquareSum = matrix[i, j] + matrix[i, j + 1]
                                                    + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (newSquareSum > biggestSum)
                    {
                        biggestSum = newSquareSum;
                        biggestCol = j;
                        biggestRow = i;
                    }
                }
            }

            Console.WriteLine($"{matrix[biggestRow, biggestCol]} {matrix[biggestRow, biggestCol + 1]}");
            Console.WriteLine($"{matrix[biggestRow + 1, biggestCol]} {matrix[biggestRow + 1, biggestCol + 1]}");
            Console.WriteLine(biggestSum);



        }

        private static int[] ArrayReadFromConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
