using System;

namespace Solid
{
    class Program
    {
        static void SingleResponsability()
        {
            // Wrong
            var customer1 = new SingleResponsability.BreakingTheRule.Customer();
            customer1.Save();
            customer1.Update();
            customer1.SendEmail();
            customer1.SendSMS();

            // Better (but could be generic)
            var customer2 = new SingleResponsability.Solution.Customer();
            var emailService = new SingleResponsability.Solution.CustomerEmailService();
            var repository = new SingleResponsability.Solution.CustomerRepository();
            var smsService = new SingleResponsability.Solution.CustomerSMSService();
            emailService.SendTo(customer2);
            repository.Save(customer2);
            repository.Update(customer2);
            smsService.SendTo(customer2);
        }

        static void Main(string[] args)
        {
            SingleResponsability();
        }
    }
}
