using System;
using System.Collections.Generic;
using strategy.Models.Implementado;
using strategy.Models.Strategy1;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<ICustomer>();

            for (int i = 1; i <= 2; i++)
            {
                customers.Add(new PhysicalCustomer()
                {
                    Id = i,
                    Nome = $"PhysicalCustomer{i}",
                    Telefone = $"Tel: {i}",
                    Email = $"customer{i}@gmail.com",
                    Cpf = $"Cpf{i}"
                });

                customers.Add(new LegalCustomer()
                {
                    Id = i,
                    Nome = $"LegalCustomer{i}",
                    Telefone = $"Tel: {i}",
                    Email = $"customer{i}@gmail.com",
                    Cnpj = $"Cnpj{i}",
                    RazaoSocial = $"RazaoSocial{i}"
                });
            }

            customers.ForEach(CustomerService.Save);
        }
    }
}
