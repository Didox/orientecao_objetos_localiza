using System;
using System.Collections.Generic;
using Database;

namespace Negocio
{
    public class CarroService
    {
        public static List<Carro> Todos()
        {
            var carros = DbServiceGenerics.Todos<Carro>();
            foreach(var carro in carros)
            {
                carro.Nome += "- Danilo";
            }
            return carros;
        }
    }
}