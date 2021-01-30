using System;
using System.Collections.Generic;
using System.Text;
using DataBase;

namespace Negocio
{
    public class CarroService
    {

        public void Salvar(Carro carro)
        {
            CarroDBService.Salvar(carro);
        }
    }
}
