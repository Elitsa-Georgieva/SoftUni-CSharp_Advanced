using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleList = Console.ReadLine().Split().ToList();

            List<string> filters = new List<string>();
            string input = Console.ReadLine();
            while (input != "Print")
            {
                string[] command = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Add filter")
                {
                   filters.Add(command[1] + " " + command[2]); 
                }
                else if (command[0] == "Remove filter")
                {
                    filters.Remove(command[1] + " " + command[2]);
                }

                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                string[] commands = filter.Split(" ");

                if (commands[0] == "Starts")
                {
                    peopleList = peopleList.Where(p => !p.StartsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Ends")
                {
                    peopleList = peopleList.Where(p => !p.EndsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Length")
                {
                    peopleList = peopleList.Where(p => p.Length != int.Parse(commands[1])).ToList();
                }
                else if (commands[0] == "Contains")
                {
                    peopleList = peopleList.Where(p => !p.Contains(commands[1])).ToList();
                }
            }

            if (peopleList.Any())
            {
                Console.WriteLine(string.Join(" ", peopleList));
            }
        }
    }
}
