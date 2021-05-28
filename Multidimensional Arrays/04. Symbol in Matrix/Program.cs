using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSizes = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSizes, matrixSizes];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                string rowValues = Console.ReadLine();

                char[] rowChars = rowValues.ToCharArray();
                

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowChars[j];
                }

            }
            
            char symbol = char.Parse(Console.ReadLine());

            //Find the first occurrence of that symbol in the matrix and print its position
            //in the format: "({row}, {col})". If there is no such symbol print an error message 
            //"{symbol} does not occur in the matrix "

            bool doesOccur = false;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        doesOccur = true;
                        break;
                    }
                }

            }

            if (!doesOccur)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix ");
            }
            
        }
    }
}
