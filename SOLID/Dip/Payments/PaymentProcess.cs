using SOLID.Dip.Factory;
using SOLID.Dip.Model;
using System;

namespace SOLID.Dip.Payments
{
    class PaymentProcess
    {
        public void Pay(string id)
        {
            DbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);

            Console.WriteLine(productData);
        }
    }
}
