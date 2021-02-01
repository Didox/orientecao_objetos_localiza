using System;
using Strategy.Dominio.Entidade;
using Strategy.Dominio.UseCase;
using Strategy.Services;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadeUseCase.Salvar(new Cliente(){
                Nome = "Danilo",
                Telefone = "1wqqww"
            });

            DbService.Instancia().Fechar();
            SmsService.Instancia().Fechar();
            EmailService.Instancia().Fechar();
        }
    }
}
