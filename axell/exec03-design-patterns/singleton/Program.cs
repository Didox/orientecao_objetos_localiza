using System;
using singleton.Domain.Entities;
using singleton.Domain.UseCases;
using singleton.Services;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityUseCase.Save(new Customer()
            {
                Id = 1,
                Nome = "Nome",
                Telefone = "Telefone",
                Email = "Email",
            });

            DbService.Close();
            EmailService.Close();
            SMSService.Close();
        }
    }
}
