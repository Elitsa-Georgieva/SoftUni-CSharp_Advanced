using System;
using System.Collections;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reversedStack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reversedStack.Push(input[i]);
            }

            /*
            Stack<string> reversedStack = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                reversedStack.Push(input[i].ToString());   
            }
            */

            while (reversedStack.Count > 0)
            {
                Console.Write(reversedStack.Pop());
            }

            Console.WriteLine();
        }
    }
}
