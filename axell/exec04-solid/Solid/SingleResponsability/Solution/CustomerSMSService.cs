using System;

namespace Solid.SingleResponsability.Solution
{
    class CustomerSMSService
    {
        public bool SendTo(Customer customer)
        {
            Console.WriteLine($"Sending SMS for customer {customer.Name}");
            return true;
        }
    }
}
