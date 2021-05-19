using System;
using System.Collections;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Stack<string> expressions = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                expressions.Push(input[i]);
            }

            while (expressions.Count > 1)
            {
                int leftNum = int.Parse(expressions.Pop());
                string sign = expressions.Pop();
                int rightNum = int.Parse(expressions.Pop());

                if (sign == "+")
                {
                    expressions.Push((leftNum + rightNum).ToString());
                }
                else if (sign == "-")
                {
                    expressions.Push((leftNum - rightNum).ToString());
                }
            }

            Console.WriteLine(expressions.Pop());
        }
    }
}
