using System;
using System.Linq;

namespace _2._Squares_in_Matrix
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

            char[,] matrix = ReadMatrix(rows, cols);

            int count = 0;

            for (int i = 0; i <= rows - 2; i++)
            {
                for (int j = 0; j <= cols - 2; j++)
                {
                    //A B B D
                    //E B B B
                    //I J B B

                    if (matrix[i, j] == matrix[i, j + 1] &&  // A -> B
                        matrix[i, j] == matrix[i + 1, j] &&  // A -> E
                        matrix[i, j] == matrix[i + 1, j + 1])// A -> B
                    {
                        count++;
                    }
                }
            }

            
            Console.WriteLine(count);

        }

        

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                char[] rowValues = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
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
