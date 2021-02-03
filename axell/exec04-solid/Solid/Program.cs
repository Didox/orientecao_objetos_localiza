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

        static void OpenClosed()
        {
            // Wrong
            var customer1 = new OpenClosed.BreakingTheRule.Customer();
            customer1.CustomerType = Solid.OpenClosed.BreakingTheRule.CustomerType.Legal;
            Console.WriteLine($"Wrong open closed customer value: {customer1.GetValue()}");
            customer1.CustomerType = Solid.OpenClosed.BreakingTheRule.CustomerType.AutonomousLegal;
            Console.WriteLine($"Wrong open closed customer value: {customer1.GetValue()}");
            customer1.CustomerType = Solid.OpenClosed.BreakingTheRule.CustomerType.NonLegal;
            Console.WriteLine($"Wrong open closed customer value: {customer1.GetValue()}");

            // Better
            OpenClosed.Solution.ICustomer customer2 = new OpenClosed.Solution.LegalCustomer();
            Console.WriteLine($"Right open closed customer value: {customer2.GetValue()}");
            customer2 = new OpenClosed.Solution.AutonomousLegalCustomer();
            Console.WriteLine($"Right open closed customer value: {customer2.GetValue()}");
            customer2 = new OpenClosed.Solution.NonLegalCustomer();
            Console.WriteLine($"Right open closed customer value: {customer2.GetValue()}");
        }

        static void Main(string[] args)
        {
            SingleResponsability();
            Console.WriteLine("-----------------------");
            OpenClosed();
        }
    }
}
