using System;
using System.Collections.Generic;
using Database;

namespace Negocios
{
    public sealed class NegocioService
    {
         public static void Salvar<T>(T carro)
        {
            DbServiceGenerics.Salvar(carro);
        }

        public static List<T> Todos<T>()
        {
            return DbServiceGenerics.Todos<T>();
        }
    }
}