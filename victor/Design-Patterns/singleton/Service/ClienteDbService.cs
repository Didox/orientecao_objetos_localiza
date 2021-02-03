using System;

namespace singleton.Service
{
    public class ClienteDbService
    {
        private ClienteDbService()
        {
            abrirConexao();
        }

        #region Métodos de instancia
        private void abrirConexao()
        {
            System.Console.WriteLine("abrindo conexão");
        }

        private void fechar()
        {
            System.Console.WriteLine("fechando conexão");
        }

        public void Salvar<T>(T obj)
        {
            System.Console.WriteLine($"Salvando o tipo {obj.GetType().Name}");
        }
        #endregion

        private static ClienteDbService clienteDbService;

        public static ClienteDbService CriarInstancia()
        {
            if (clienteDbService == null) clienteDbService = new ClienteDbService();
            return clienteDbService;

        }

        public static void Fechar()
        {
            clienteDbService.fechar();
            clienteDbService = null;
        }

    }
}