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

        

        public void SalvarHatch()
        {
            var carro = new Hatch();
            carro.Salvar();
            carro.SalvarVirtual();
        }

    }
}