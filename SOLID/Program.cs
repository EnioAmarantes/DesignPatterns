using System;
using SOLID.Lsp.Payments;
using SOLID.Ocp;
using SOLID.Isp;
using SOLID.Dip.Payments;

namespace SOLID
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
