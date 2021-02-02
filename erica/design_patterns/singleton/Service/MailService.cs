namespace singleton.Service
{
    public class MailService :IService
    {
        private EmailService(){}

    #region Métodos de instância
    public void Enviar<T>(T obj){
      Console.WriteLine($"Enviando e-mail para o tipo {obj.GetType().Name}");
    }

    public void Fechar(){
      entidadeEmailService = null;
    }
    #endregion

    private static EmailService entidadeEmailService;

    public static EmailService Instancia(){
      if(entidadeEmailService == null) entidadeEmailService = new EmailService();
      return entidadeEmailService;
    }
    }
}