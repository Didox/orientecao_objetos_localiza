using System;
using System.Collections.Generic;
using System.Text;
using DataBase;

namespace Negocio
{
    public class CarroServico
    {

        public void Salvar(Carro carro)
        {
            DBServicesGenerics.Salvar(carro);
        }
    }
}
