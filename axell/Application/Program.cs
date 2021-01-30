using System.Collections.Generic;
using Business.Models;
using Business.Services;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>();

            for (int i = 1; i <= 3; i++)
            {
                customers.Add(new Customer(i, $"Customer{i}", "9999 9999 9999 9999"));
            }

            customers.ForEach(CustomerService.Save);
        }
    }
}
