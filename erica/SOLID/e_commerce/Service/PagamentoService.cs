namespace e_commerce
{
    public class PagamentoService : IService
    {
          private PagamentoService(){}

    #region instancia
        public void Enviar<T>(T obj){
            Console.WriteLine($"Pagamento do tipo {obj.GetType().Name}");
        }
        public void Fechar(){
            entidadePagamentoService = null;
        }
    #endregion

    private static PagamentoService entidadePagamentoService;
    private static object entidadeDbService;

    public static PagamentoService instancia(){
      if(entidadePagamentoService == null) entidadePagamentoService = new PagamentoService();
      return entidadePagamentoService;
      }
    }
}