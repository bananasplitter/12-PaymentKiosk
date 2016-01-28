using PaymentKiosk.core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentKiosk.core
{
    public class Customer
    {
        public string FullName { get; set; }
        public string TelephoneNumber { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
