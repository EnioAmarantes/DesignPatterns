using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Lsp.Payments
{
    class CreditCard: NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando Limite...");
            Console.WriteLine("Limite OK!");
        }
    }
}
