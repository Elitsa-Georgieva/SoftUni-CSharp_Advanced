using System.Reflection.Metadata;

namespace _07.RawData
{
    public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EnginePower = enginePower;
            EngineSpeed = engineSpeed;
        }
        public int EngineSpeed { get; set; }

        public int EnginePower { get; set; }
        
    }
}
