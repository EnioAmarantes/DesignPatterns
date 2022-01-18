using System;

namespace SOLID.Ocp.Violando
{
    class Vehicle
    {
        private string color;
        private int year;
        private double engine;
        private int seats;
        private int doors;

        public Vehicle(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;
        }

        public void Car()
        {
            Console.WriteLine($"Criando um Carro {color}, {year}, {engine}, {doors} portas e {seats} assentos.");
        }
        public void Motorcycle()
        {
            Console.WriteLine($"Cri ando uma Moto {color}, {year}, {engine} cilindradas.");
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os Motores");
        }
    }
}
