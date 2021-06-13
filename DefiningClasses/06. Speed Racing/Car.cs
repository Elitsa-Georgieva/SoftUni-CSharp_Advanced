using System;

namespace _6.SpeedRacing
{
    public class Car
    {
        public Car(string model, decimal fuelAmount, decimal fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }
        public string Model { get; set; }

        public decimal FuelAmount { get; set; }

        public decimal FuelConsumptionPerKilometer { get; set; }

        public decimal TravelledDistance { get; set; }


        public void Drive(decimal distance)
        {
            decimal fuelNeeded = distance * FuelConsumptionPerKilometer;
            if (FuelAmount >= fuelNeeded)
            {
                FuelAmount -= fuelNeeded;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }
    }
}
