using System;
using System.Collections.Generic;

namespace Strategy.Modelos.Implementado
{
    public class ClientesService
    {
        public static List<IPessoa> Todos()
        {
            return new List<IPessoa>();
        }
        
        public static List<T> Todos<T>()
        {
            return new List<T>();
        }
    }
}