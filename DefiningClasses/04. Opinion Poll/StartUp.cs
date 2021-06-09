using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            ////T01
            //Person pesho = new Person()
            //{
            //    Name = "Pesho",
            //    Age = 20
            //};


            //Console.WriteLine($"{pesho.Name} {pesho.Age}");

            //Console.WriteLine("---------------------------------------------");

            ////T02
            //var noName = new Person();
            //Console.WriteLine($"NoNameGuy: {noName.Name} {noName.Age}");
            //var gosho = new Person(24);
            //Console.WriteLine($"GoshoYear: {gosho.Name} {gosho.Age}");
            //var stamat = new Person("Stamat", 27);
            //Console.WriteLine($"Stamat: {stamat.Name} {stamat.Age}");

            int n = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);

                var person = new Person(name, age);
                family.AddMember(person);
            }

            //T03
            //Console.WriteLine(family.GetOldestMember());

            HashSet<Person> personAbove30 = family.GetAllPeopleOver30();
            Console.WriteLine(string.Join(Environment.NewLine, personAbove30));


        }
    }
}
