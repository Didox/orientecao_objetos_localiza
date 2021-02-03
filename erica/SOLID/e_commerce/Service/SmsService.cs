namespace e_commerce
{
    public class PagamentoService : IService
    {
        private PagamentoService(){}

    #region instancia
        public void Enviar<T>(T obj){
            Console.WriteLine($"Enviando SMS do tipo {obj.GetType().Name}");
        }
        public void Fechar(){
            entidadeSmsService = null;
        }
    #endregion

    private static PagamentoService entidadeSmsService;
    private static object entidadeDbService;

    public static PagamentoService instancia(){
      if(entidadeSmsService == null) entidadeSmsService = new PagamentoService();
      return entidadeSmsService;
      }
    }
}