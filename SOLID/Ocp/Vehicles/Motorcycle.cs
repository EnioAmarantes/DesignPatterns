using System;

namespace SOLID.Ocp.Vehicles
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string color, int year, double engine)
                : base(color, year, engine)
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Cri ando uma Moto {color}, {year}, {engine} cilindradas.");
            StartVehicle();
        }
    }
}
