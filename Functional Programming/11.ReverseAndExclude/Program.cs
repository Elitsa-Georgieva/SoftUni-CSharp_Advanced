using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int divisibleNumber = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % divisibleNumber != 0;
            //филтър, който ще ни избира числата, които не се делят на divisibleNumber
            Action<int[]> printer = x => Console.WriteLine(string.Join(" ", x.Reverse()
                .Where(x => filter(x))));
            printer(numbers);

        }
    }
}
