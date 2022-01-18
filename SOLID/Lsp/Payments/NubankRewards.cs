using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Lsp.Payments
{
    class NubankRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");
            Console.WriteLine("Pontuação creditada");
        }

        public void Validate()
        {
            Console.WriteLine("Limite OK, Rewards OK!");
        }
    }
}
