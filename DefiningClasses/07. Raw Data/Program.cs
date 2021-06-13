using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                //за всяка една кола
                string[] info = Console.ReadLine().Split();
                
                //за всеки един двигател
                string carModel = info[0];
                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);
                Engine engine = new Engine(engineSpeed, enginePower);
                
                //за всеки товар
                int cargoWeigth = int.Parse(info[3]);
                string cargoType = info[4];
                Cargo cargo = new Cargo(cargoWeigth, cargoType);
                
                //правим си колекция от гуми
                
                var tire = new []
                //var tire = new Tire[]
                {
                    new Tire(double.Parse(info[5]), int.Parse(info[6])),
                    new Tire(double.Parse(info[7]), int.Parse(info[8])),
                    new Tire(double.Parse(info[9]), int.Parse(info[10])),
                    new Tire(double.Parse(info[11]), int.Parse(info[12]))
                };

                cars.Add(new Car(carModel, engine, cargo, tire));


            }

            string typeOfCargo = Console.ReadLine();
            List<Car> filteredCars = new List<Car>();

            if (typeOfCargo == "fragile")
            {
                filteredCars = cars.Where(c => c.Cargo.CargoType == "fragile"
                                               && c.Tire.Any(t => t.TirePressure < 1)).ToList();
            }
            else if (typeOfCargo == "flamable")
            {
                filteredCars = cars.Where(c => c.Cargo.CargoType == "flamable"
                                               && c.Engine.EnginePower > 250).ToList();
            }

            foreach (Car car in filteredCars)
            {
                Console.WriteLine(car.Model);
            }
        }

    }
}
