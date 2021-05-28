using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> citiesByContinentsAndCountries
                = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ");

                string continent = data[0];
                string countrie = data[1];
                string city = data[2];

                if (citiesByContinentsAndCountries.ContainsKey(continent) == false)
                {
                    citiesByContinentsAndCountries.Add(continent, new Dictionary<string, List<string>>());
                }

                if (citiesByContinentsAndCountries[continent].ContainsKey(countrie) == false) 
                {
                    citiesByContinentsAndCountries[continent].Add(countrie, new List<string>());
                }

                citiesByContinentsAndCountries[continent][countrie].Add(city);

            }


            //Europe:
              //Bulgaria->Sofia, Plovdiv
              //Poland->Warsaw, Poznan
              //Germany->Berlin

              foreach (var kvp in citiesByContinentsAndCountries)
              {
                  Console.WriteLine($"{kvp.Key}:");

                  Dictionary<string, List<string>> countries = kvp.Value;

                    foreach (var country in countries)
                    {
                        Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                    }
              }

        }
    }
}
