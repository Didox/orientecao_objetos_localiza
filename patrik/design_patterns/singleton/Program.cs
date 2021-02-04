using singleton.Modelos;
using singleton.Modelos.Entidade;
using singleton.Modelos.UseCase;
using singleton.Services;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadeUseCase.Salvar<Clientes>(new Clientes()
            {
                Nome = "Patrik Oliveira",
                Email = "patrik@gmail.com",
                Telefone = "3133333333"
            });
            
            DbService.Instancia().Fechar();
            MailService.Instancia().Fechar();
            SmsService.Instancia().Fechar();
        }
    }
}
