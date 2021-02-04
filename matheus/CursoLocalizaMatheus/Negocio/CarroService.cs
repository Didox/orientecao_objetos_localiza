using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class CarroService
    {

        public static void Salvar(Carro carro)
        {
            CarroDBService.Salvar(carro);
        }
    }
}
