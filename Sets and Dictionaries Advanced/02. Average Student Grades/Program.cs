using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentsInfo = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                decimal grade = decimal.Parse(tokens[1]);

                if (studentsInfo.ContainsKey(name) == false)
                {
                    studentsInfo.Add(name, new List<decimal>()
                    {
                        grade
                    });
                }
                else
                {
                    studentsInfo[name].Add(grade);
                }


            }

            foreach (var kvp in studentsInfo)
            {
                string name = kvp.Key;
                List<decimal> studentGrades = kvp.Value;
                decimal average = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.WriteLine($"(avg: {average:F2})");
            }

            //foreach (var kvp in studentsInfo)
            //{
            //    Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value.Select(v => v.ToString("F2")))} (avg: {kvp.Value.Average():F2})");
            //}
        }
    }
}
