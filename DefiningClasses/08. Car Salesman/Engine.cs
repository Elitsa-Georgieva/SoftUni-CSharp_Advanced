using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Engine
    {
        public Engine(string engineModel, int power)
        {
            EngineModel = engineModel;
            Power = power;
        }
        public string EngineModel { get; set; }
        public int  Power { get; set; }

        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{EngineModel}:");
            sb.AppendLine();
            sb.Append($"    Power: {Power}");
            sb.AppendLine();
            sb.Append(Displacement == 0 ? "    Displacement: n/a" : $"    Displacement: {Displacement}");
            sb.AppendLine();
            sb.Append(string.IsNullOrEmpty(Efficiency) ? "    Efficiency: n/a" : $"    Efficiency: {Efficiency}");
            return sb.ToString().TrimEnd();
        }
    }
}
