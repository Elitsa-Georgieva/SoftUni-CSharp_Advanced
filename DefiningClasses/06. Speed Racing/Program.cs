using System;
using System.Linq;

namespace _6.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //получаваме броя на колите които ще следим

            var cars = new Car[n];

            //създаваме масива от коли
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = tokens[0];
                var fuelAmount = decimal.Parse(tokens[1]);
                var fuelCost = decimal.Parse(tokens[2]);
                //въртим коли, за текущата създаваме Обект Car, който получава fuelAmount и fuelCost. 
                cars[i] = new Car(model, fuelAmount, fuelCost);

            }

            while (true)
            {
                var input = Console.ReadLine();
                var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input == "End")
                {
                    break;
                }

                var model = tokens[1];
                decimal distance = decimal.Parse(tokens[2]);
                cars.Where(c => c.Model == model).ToList().ForEach(c => c.Drive(distance));
                //искам да ми намериш от масива от обекти cars, само колите, чиито модел отговаря на подадения
                //тука модел, да ни ги запишеш в лист, и после всяка една от колите от новия лист да й дадеш 
                //метода Drive, на който подаваме параметъра distance;
            }

            foreach (Car car in cars)
            {
               Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}"); 
            }

        }
    }
}
