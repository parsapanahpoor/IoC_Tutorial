using System;

namespace DependencyInjection._04
{
    public class Buy
    {

        private readonly IPayment _payment;

        public Buy(IPayment payment)
        {
            _payment = payment;
        }

        public void Pay()
        {
           Console.WriteLine( _payment.Pay());
        }
    }
}
