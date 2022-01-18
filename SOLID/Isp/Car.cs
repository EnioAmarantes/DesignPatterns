using System;

namespace SOLID.Isp
{
    class Car : AVehicle, IVehiclCar
    {
        private int seats;
        private int doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;

            Console.WriteLine($"Criando carro da cor {color}, ano {year}, com motor {engine}, {doors} portas com {seats} lugares.");
            StartVehicle();
        }

        public override void StartVehicle()
        {
            Console.WriteLine("Ligando o veículo....");
        }
    }
}
