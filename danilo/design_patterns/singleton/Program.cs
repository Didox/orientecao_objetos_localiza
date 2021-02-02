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
            EntidadeUseCase.ListaAcoes.Add(EmailService.Instancia());
            EntidadeUseCase.ListaAcoes.Add(SmsService.Instancia());
            EntidadeUseCase.ListaAcoes.Add(DbService.Instancia());
            
            //EntidadeUseCase.ListaAcoes.Add(MongoService.Instancia());
            //EntidadeUseCase.ListaAcoes.Add(ElascService.Instancia());

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
