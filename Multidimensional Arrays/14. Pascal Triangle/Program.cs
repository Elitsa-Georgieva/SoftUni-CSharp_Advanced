using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascal = new long[n][];

            int cols = 1;
            
            for (int row = 0; row < pascal.Length; row++)
            {
                pascal[row] = new long[cols];
                pascal[row][0] = 1;
                pascal[row][pascal[row].Length - 1] = 1;

                if (row > 1)
                {
                    for (int col = 1; col < pascal[row].Length - 1; col++)
                    {
                        //1
                        //1 1
                        //1 0 1
                        //1 0 0 1

                        //pascal[2][1] = pascal[1][1] + pascal[1][0];
                        //1
                        //1 1
                        //1 2 1
                        //1 0 0 1
                        //pascal[3][1] = pascal[2][1] + pascal[2][0];
                        //pascal[3][2] = pascal[2][2] + pascal[2][1];
                        long[] prevRow = pascal[row - 1];
                        //row[] 2 = 1 2 1
                        //pascal[3][1]

                        long firstNum = prevRow[col];
                        //pascal[3][1] 
                        //firstNum = pascal[2][1]
                        long secondSum = prevRow[col - 1];
                        pascal[row][col] = firstNum + secondSum;

                    }
                }

                cols++;
                
            }

            for (int row = 0; row < pascal.Length; row++)
            {
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    Console.Write(pascal[row][col] + " ");
                }
                Console.WriteLine();
            }

            
        }
    }
}
