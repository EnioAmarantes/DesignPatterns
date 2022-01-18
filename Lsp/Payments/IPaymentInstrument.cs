namespace SOLID.Lsp.Payments
{
    interface IPaymentInstrument
    {
        void Validate();
        void CollectPayment();
    }
}
