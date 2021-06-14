using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleList = Console.ReadLine().Split().ToList();
            
            List<string> filters = new List<string>();
            string input = Console.ReadLine();
            while (input != "Party!")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Remove")
                {
                    if (command[1] == "StartsWith")
                    {
                        peopleList.RemoveAll(x => x.StartsWith(command[2]));
                        //peopleList = peopleList.Where(p => !p.StartsWith(command[2])).ToList();
                    }
                    else if (command[1] == "EndsWith")
                    {
                        peopleList.RemoveAll(x => x.EndsWith(command[2]));
                        //peopleList = peopleList.Where(p => !p.EndsWith(command[2])).ToList();
                    }
                    else if (command[1] == "Length")
                    {
                        peopleList.RemoveAll(x => x.Length == int.Parse(command[2]));
                        //peopleList.Where(p => p.Length == int.Parse(command[2])).ToList();
                    }
                }
                else if (command[0] == "Double")
                {

                    if (command[1] == "StartsWith")
                    {
                        List<string> nameToDouble = peopleList.Where(p => p.StartsWith(command[2])).ToList();

                        if (nameToDouble.Count > 0)
                        {
                            int index = peopleList.FindIndex(x => x.StartsWith(command[2]));

                            peopleList.InsertRange(index, nameToDouble);
                        }
                        
                    }
                    else if (command[1] == "EndsWith")
                    {
                        List<string> nameToDouble = peopleList.Where(p => p.EndsWith(command[2])).ToList();

                        if (nameToDouble.Count > 0)
                        {
                            int index = peopleList.FindIndex(x => x.EndsWith(command[2]));

                            peopleList.InsertRange(index, nameToDouble);
                        }
                    }
                    else if (command[1] == "Length")
                    {
                        List<string> nameToDouble = peopleList.Where(p => p.Length == int.Parse(command[2])).ToList();

                        if (nameToDouble.Count > 0)
                        {
                            int index = peopleList.FindIndex(p => p.Length == int.Parse(command[2]));

                            peopleList.InsertRange(index, nameToDouble);
                        }
                    }


                }

                input = Console.ReadLine();
            }
            
            

            //foreach (var filter in filters)
            //{
            //    string[] commands = filter.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    if (commands[0] == "StartsWith")
            //    {
            //        peopleList = peopleList.Where(p => !p.StartsWith(commands[1])).ToList();
            //    }
            //    else if (commands[0] == "EndsWith")
            //    {
            //        peopleList = peopleList.Where(p => !p.EndsWith(commands[1])).ToList();
            //    }
            //    else if (commands[0] == "Length")
            //    {
            //        peopleList.Where(p => p.Length == int.Parse(commands[1])).ToList();
            //    }
                
            //}

            if (peopleList.Any())
            {
                Console.WriteLine(string.Join(", ", peopleList) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
