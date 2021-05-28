using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizesOfMatrix = ArrayReadFromConsole();

            int[,] matrix = new int[sizesOfMatrix[0], sizesOfMatrix[1]];

            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] colArr = ArrayReadFromConsoleWithSpace();

                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = colArr[j];
                }

                
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int colSum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    colSum += matrix[i, j];
                }

                Console.WriteLine(colSum);
            }

            
        }

        private static int[] ArrayReadFromConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        private static int[] ArrayReadFromConsoleWithSpace()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
