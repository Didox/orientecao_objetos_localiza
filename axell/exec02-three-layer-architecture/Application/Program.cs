using System;
using System.Collections.Generic;
using Business.Models;
using Business.Services;

namespace Application
{
    class Program
    {
        static void Generics()
        {
            Console.WriteLine("Generics");
            var customers = new List<Customer>();

            for (int i = 1; i <= 3; i++)
            {
                customers.Add(new Customer(i, $"Customer{i}", "9999 9999 9999 9999"));
            }

            customers.ForEach(BaseService.Save);

            var customerList = BaseService.List<Customer>();
            customerList.ForEach(customer => Console.WriteLine(customer.Details()));
            Console.WriteLine();
        }

        static void NonGenerics()
        {
            Console.WriteLine("NonGenerics");
            var customers = new List<Customer>();

            for (int i = 1; i <= 3; i++)
            {
                customers.Add(new Customer(i, $"Customer{i}", "9999 9999 9999 9999"));
            }

            customers.ForEach(NonGenericBaseService.Save);

            var customerList = NonGenericBaseService.List();
            customerList.ForEach(customer => Console.WriteLine(((Customer)customer).Details()));
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Generics();
            NonGenerics();
        }
    }
}
