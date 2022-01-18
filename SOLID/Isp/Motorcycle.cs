using System;

namespace SOLID.Isp
{
    class Motorcycle : AVehicle, IVehicleMotorcycle
    {
        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;

            Console.WriteLine($"Criando uma Moto da cor {color}, ano {year}, com motor {engine} cilindradas.");
            StartVehicle();
        }

        public override void StartVehicle()
        {
            Console.WriteLine("Ligando o veículo....");
        }
    }
}
