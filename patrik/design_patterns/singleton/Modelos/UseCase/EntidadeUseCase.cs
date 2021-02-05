using singleton.Services;

namespace singleton.Modelos.UseCase
{
    public class EntidadeUseCase
    {
        public static void Salvar<T>(T entidade)
        {
            DbService.Instancia().Salvar(entidade);
            MailService.Instancia().Enviar(entidade);
            SmsService.Instancia().Enviar(entidade);
        }
    }
}