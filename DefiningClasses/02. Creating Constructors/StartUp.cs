using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            //T01
            Person pesho = new Person()
            {
                Name = "Pesho",
                Age = 20
            };


            Console.WriteLine($"{pesho.Name} {pesho.Age}");

            Console.WriteLine("---------------------------------------------");

            //T02
            var noName = new Person();
            Console.WriteLine($"NoNameGuy: {noName.Name} {noName.Age}");
            var gosho = new Person(24);
            Console.WriteLine($"GoshoYear: {gosho.Name} {gosho.Age}");
            var stamat = new Person("Stamat", 27);
            Console.WriteLine($"Stamat: {stamat.Name} {stamat.Age}");






        }
    }
}
