using System;

namespace SOLID.Lsp.Payments
{
    abstract class NubankCard : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado!");
        }

        public virtual void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
