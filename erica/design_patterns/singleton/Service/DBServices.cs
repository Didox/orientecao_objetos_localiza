namespace singleton.Service
{
    public class DBServices :IService
    {
        private DbService() {
            abrirConexao();
        }

    #region Métodos de instância //organizacao de código
        private void abrirConexao(){
        Console.WriteLine("Abrindo conexão.");
        }
        private void fechar(){
        Console.WriteLine("Fechando conexão.");
        }

        public void Enviar<T>(T obj){
        Console.WriteLine($"Salvando o tipo {obj.GetType().Name}");
        }
        public void Fechar(){
        entidadeDbService.fechar();
        entidadeDbService = null;
        }
    #endregion //fim organizacao codigo

    private static DBService entidadeDbService;

    public static DbService Instancia(){
      if(entidadeDbService == null) entidadeDbService = new DbService();
      return entidadeDbService;
    }
}
}