using System;

namespace Solid.SingleResponsability.Solution
{
    class CustomerRepository
    {
        public bool Save(Customer customer)
        {
            Console.WriteLine($"Saving customer {customer.Name}");
            return true;
        }

        public bool Update(Customer customer)
        {
            Console.WriteLine($"Updating customer {customer.Name}");
            return true;
        }
    }
}
