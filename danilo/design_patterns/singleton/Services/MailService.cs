

using System;

namespace Strategy.Services
{
  public class EmailService : IService
  {
    private EmailService()
    {
    }

    #region Métodos de instancia
    public void Enviar<T>(T obj)
    {
      Console.WriteLine($"Enviando email para o tipo {obj.GetType().Name}");
    }

    public void Fechar()
    {
      entidadeEmailService = null;
    }
    #endregion

    private static EmailService entidadeEmailService;

    public static EmailService Instancia()
    {
      if(entidadeEmailService == null) entidadeEmailService = new EmailService();
      return entidadeEmailService;
    }
  }
}