using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. ЧЕТЕМ ОТ КОНЗОЛАТА

            int[] sizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //3, 6
                //7, 1, 3, 3, 2, 1
                int[] colElements = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = colElements[j];
                    //0, 0 = 7
                    //0, 1 = 1
                    //0, 2 = 3
                    //0, 3 = 3
                    //0, 4 = 2
                    //0, 5 = 1

                    //1, 3, 9, 8, 5, 6
                    //1, 0 = 
                }
            }

            //2. СУМИРАМЕ СТОЙНОСТИТЕ ОТ МАТРИЦАТА

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }

            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
