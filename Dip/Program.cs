using SOLID.Dip.Payments;
using System;

namespace Dip
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcess payment = new PaymentProcess();
            payment.Pay("ABC123");

            Console.ReadLine();
        }
    }
}
