using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Isp.Violando.Vehicles
{
    class MotorCycle : IVehicle
    {
        private string color;
        private int year;
        private double engine;

        public MotorCycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }
        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            throw new NotImplementedException();
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {

            this.color = color;
            this.year = year;
            this.engine = engine;

            Console.WriteLine($"Criando moto ano {year}, motor {engine}, da cor {color}.");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os Motores");
        }
    }
}
