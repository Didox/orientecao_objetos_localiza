
using System;

namespace Strategy.Services
{
  public class DbService : IService
  {
    private DbService()
    {
      abrirConexao();
    }

    #region Métodos de instancia
    private void abrirConexao()
    {
      Console.WriteLine("Abrindo conexão");
    }
    private void fechar()
    {
      Console.WriteLine("Fechando conexão");
    }

    public void Enviar<T>(T obj)
    {
      Console.WriteLine($"Salvando o tipo {obj.GetType().Name}");
    }
    public void Fechar()
    {
      entidadeDbService.fechar();
      entidadeDbService = null;
    }
    #endregion

    private static DbService entidadeDbService;

    public static DbService Instancia()
    {
      if(entidadeDbService == null) entidadeDbService = new DbService();
      return entidadeDbService;
    }
  }
}