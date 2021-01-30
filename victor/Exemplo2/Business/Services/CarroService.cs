using Business.Model;
using Database;

namespace Business.Services
{
    public class CarroService
    {
        public void Salvar(Carro carro)
        {
            CarroDbService.Salvar(carro);
        }
        
    }
}