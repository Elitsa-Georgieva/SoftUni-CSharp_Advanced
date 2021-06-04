using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = s => s[0] == s.ToUpper()[0];
            //СЪЩОТО!!! Predicate<string> predicate = s => char.IsUpper(s[0]);
            
            //взимаме първата буква от стринга и проверяваме дали е равна на първата буква от стринга като главна

            //СЪЩОТО!!! като Func<string, bool> predicate = s => s[0] == s.ToUpper()[0];

            //Predicate е функция (и делегат), която получава някакви параметри и връща bool

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                //Where очаква Predicate по принцип
                .Where(w => predicate(w))
                .ToList()
                .ForEach(w => Console.WriteLine(w));

           
        }
    }
}
