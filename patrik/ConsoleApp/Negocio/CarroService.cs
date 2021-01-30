using System;

namespace Negocio
{
    public class CarroService
    {
        public void Salvar(Carro carro)
        {
            Database.CarroService.Salvar(carro);
        }
    }
}