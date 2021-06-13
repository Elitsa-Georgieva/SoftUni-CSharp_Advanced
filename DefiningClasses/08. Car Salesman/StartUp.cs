using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace _08.CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] info = Console.ReadLine().Split();
                engines.Add(CreateEngine(info));
            }

            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] info = Console.ReadLine().Split();
                //The engine will be the model of an existing Engine. 
                cars.Add(CreateCar(info, engines));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public static Car CreateCar(string[] info, List<Engine> engines)
        {
            var carModel = info[0];
            var engineModel = info[1];
            //engine за текущата кола
            Engine engine = engines.Find(e => e.EngineModel == engineModel);
            var car = new Car(carModel, engine);

            if (info.Length > 2)
            {
                var isDigit = int.TryParse(info[2], out int weight);
                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = info[2];
                }

                if (info.Length > 3)
                {
                    car.Color = info[3];
                }
            }

            return car;
        }

        public static Engine CreateEngine(string[] info)
        {
            string engineModel = info[0];
            int enginePower = int.Parse(info[1]);
            Engine engine = new Engine(engineModel, enginePower);

            if (info.Length > 2)
            {
                bool isDigit = int.TryParse(info[2], out int displacement);
                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = info[2];
                }

                if (info.Length > 3)
                {
                    engine.Efficiency = info[3];
                }
            }

            return engine;
        }
        
    }
}
