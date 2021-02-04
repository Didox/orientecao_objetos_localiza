using System;

namespace Solid.SingleResponsability.BreakingTheRule
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Save()
        {
            Console.WriteLine($"Saving customer {Name}");
            return true;
        }

        public bool Update()
        {
            Console.WriteLine($"Updating customer {Name}");
            return true;
        }

        public bool SendSMS()
        {
            Console.WriteLine($"Sending SMS for customer {Name}");
            return true;
        }

        public bool SendEmail()
        {
            Console.WriteLine($"Sending email for customer {Name}");
            return true;
        }
    }
}
