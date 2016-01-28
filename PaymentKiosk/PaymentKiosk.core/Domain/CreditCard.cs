using PaymentKiosk.core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentKiosk.core
{
   public class CreditCard
    {
        public string CcNumber { get; set; }
        public DateTime ExpireDate { get; set; }
        public string CVCCode { get; set; }
        public Address BillingAdress { get; set; }

    }
}
