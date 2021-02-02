using System.Collections.Generic;
using Database;

namespace Negocio
{
    public class CarroService
    {
        public void Salvar(Carro carro)
        {
            Database.CarroRepository.Salvar(carro);
        }
        
        public List<T> ListarCarros<T>()
        {
            return Database.CarroRepository.ListarCarros<T>();
        }
        
        public List<IBase> ListarCarros()
        {
            return Database.CarroRepository.ListarCarros();
        }
    }
}