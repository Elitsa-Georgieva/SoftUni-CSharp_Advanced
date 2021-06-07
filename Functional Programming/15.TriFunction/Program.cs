using System;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> validator = (name, value) => name.ToCharArray()
                .Select(currChar => (int) currChar).Sum() >= N;

            //функция, която приема string и int и връща bool -> приема име и стойност, които отиват в името като 
            //charArray, който със Select - взимаме всеки char (currChar), взимаме му (int) стойността
            //и със Sum го сумираме, след което сравняваме стойността на всеки currChar с N
            //ако функцията върне TRUE съответно ще ни върне конкретно име отговарящо на условието

            //правим функция, която приема горната функция

            Func<string[], int, Func<string, int, bool>, string> foundName = (collection, value, func) => collection.FirstOrDefault(name => func(name, value));

            //функция, която приема string[] (имената), int (N) - които предаваме на нашата Func<> validator
            //който връща bool
            //и накрая искаме да върнем string (име чиято сума на чарактарите е >= N)

            //подаваме колекция, числото по което имаме да сравняваме и функцията, която ни връща дали емето
            //отговаря на критерия
            // те ще отидат така => collection.FirstOrDefault - ще ни намери първото от колекцията, на което 
            //прилагаме func(name, value) и ни връща, че е <= N

            Console.WriteLine(foundName(names, N, validator));
        }
    }
}
