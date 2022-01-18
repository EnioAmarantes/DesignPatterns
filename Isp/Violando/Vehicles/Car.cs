using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Isp.Violando.Vehicles
{
    class Car : IVehicle
    {
        private string color;
        private int year;
        private double engine;
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

            Console.WriteLine($"Criando carro ano {year}, motor {engine}, da cor {color}.");
            StartVehicle();
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            throw new NotImplementedException();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os Motores");
        }
    }
}
