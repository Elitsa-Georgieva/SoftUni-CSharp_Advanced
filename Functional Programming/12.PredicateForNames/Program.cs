using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());

            Func<string, bool> checker = name => name.Length <= nameLength;

            var names = Console.ReadLine().Split().Where(checker).ToArray();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


            //string[] namess = Console.ReadLine().Split();
            //Action<string[]> printNamess = name =>
            //{
            //    Predicate<string> filter = name => name.Length <= nameLength;
            //    foreach (string currName in namess.Where(name => filter(name)))
            //    {
            //        Console.WriteLine(currName);
            //    }
            //};
            //printNamess(namess);

        }
    }
}
