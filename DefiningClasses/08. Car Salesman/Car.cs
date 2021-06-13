using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Car
    {
        public Car(string carModel, Engine engine)
        {
            CarModel = carModel;
            Engine = engine;
           
        }

        //•	EngineModel
        //•	Engine
        //•	Weight 
        //•	Color

        public string CarModel { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{CarModel}:");
            sb.AppendLine();
            sb.Append($"  {Engine.ToString()}");
            sb.AppendLine();
            sb.Append(Weight == 0 ? "  Weight: n/a" : $"  Weight: {Weight}");
            sb.AppendLine();
            sb.Append(String.IsNullOrEmpty(Color) ? "  Color: n/a" : $"  Color: {Color}");

            return sb.ToString().TrimEnd();
        }
    }
}
