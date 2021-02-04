using System;

namespace Solid.SingleResponsability.Solution
{
    class CustomerEmailService
    {
        public bool SendTo(Customer customer)
        {
            Console.WriteLine($"Sending email for customer {customer.Name}");
            return true;
        }
    }
}
