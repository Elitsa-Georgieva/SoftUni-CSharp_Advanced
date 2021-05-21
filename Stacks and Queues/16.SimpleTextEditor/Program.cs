using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            StringBuilder builder = new StringBuilder();

            Stack<string> stack = new Stack<string>();

            stack.Push(builder.ToString());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ');

                int command = int.Parse(input[0]);

                if (command == 1)
                {
                    builder.Append(input[1]);
                    stack.Push(builder.ToString());

                }

                else if (command == 2)
                {
                    int number = int.Parse(input[1]);
                    builder.Remove(builder.Length - number, number);
                    stack.Push(builder.ToString());
                }
                else if (command == 3)
                {
                    int idx = int.Parse(input[1]);
                    Console.WriteLine(builder[idx - 1]);
                }
                else
                {
                    stack.Pop();
                    builder = new StringBuilder();
                    builder.Append(stack.Peek());
                }
            }

        }
    }
}
