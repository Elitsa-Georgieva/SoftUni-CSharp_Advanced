using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person pesho = new Person()
            {
                Name = "Pesho",
                Age = 20
            };


            Console.WriteLine($"{pesho.Name} {pesho.Age}");


        }
    }
}
