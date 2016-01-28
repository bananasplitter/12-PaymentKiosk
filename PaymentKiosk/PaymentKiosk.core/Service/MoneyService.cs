using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentKiosk.core.Service
{
    public class MoneyService
    {
        private const string stripeApiKey = "sk_test_TN7PiTwX6CACkBrg9ohMQDjS";

        public static bool Charge(Customer customer, CreditCard creditCard, decimal amount)
        {
            var chargeDetails = new StripeChargeCreateOptions();
            chargeDetails.Amount = (int)amount * 100;
            chargeDetails.Currency = "usd";

            chargeDetails.Source = new StripeSourceOptions
            {
                Object = "card",
                Number = creditCard.CcNumber,
                ExpirationMonth = creditCard.ExpireDate.Month.ToString(),
                ExpirationYear = creditCard.ExpireDate.Year.ToString(),
                Cvc = creditCard.CVCCode
            };

            var chargeService = new StripeChargeService(stripeApiKey);

            var response = chargeService.Create(chargeDetails);

            if(response.Paid == false)
            {
                throw new Exception(response.FailureMessage);
            }

            return response.Paid;
        }
    }
}
