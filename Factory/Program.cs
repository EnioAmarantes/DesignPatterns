using Factory.Factories;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport transport = null;

            if(args.Length > 0 && args[0] == "--uber")
            {
                transport = new CarTransport();
            }
            else if(args.Length > 0 && args[0] == "--log")
            {
                transport = new MotocycleTransport();
            }
            else
            {
                Console.WriteLine("Selecione o tipo do serviço.");
            }

            if (transport != null)
                transport.StartTransport();

            Console.ReadLine();
        }
    }
}
