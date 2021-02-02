using System;
using singleton.Dominio.Entidade;
using singleton.Dominio.UseCase;
using singleton.Service;

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
                Nome = "Erica",
                Telefone = "12345"
            });

            DbService.Instancia().Fechar();
            SmsService.Instancia().Fechar();
            EmailService.Instancia().Fechar();
            //Console.WriteLine("Hello World!");
        }
    }
}
