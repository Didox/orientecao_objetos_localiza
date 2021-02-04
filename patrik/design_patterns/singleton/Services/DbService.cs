using System;

namespace singleton.Services
{
    public class DbService
    {
        private DbService()
        {
        }

        private static DbService _dbService;

        private void abrirConexao()
        {
            Console.WriteLine("Abrindo Conexão");
        }
        
        private void fechar()
        {
            Console.WriteLine("Fechando Conexão");
        }
        
        public void Salvar<T>(T obj)
        {
            Console.WriteLine($"Salvando o tipo {obj.GetType().Name}");
        }

        public static DbService Instancia()
        {
            if (_dbService == null)
            {
                _dbService = new DbService();
                _dbService.abrirConexao();
            }

            return _dbService;
        }
        
        public void Fechar()
        {
            _dbService.fechar();
            _dbService = null;
        }
    }
}