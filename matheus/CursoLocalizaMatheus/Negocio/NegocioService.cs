using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class NegocioService
    {


        public static List<T> Todos<T>()
        {
            return DbServiceGeneric.Todos<T>();
        }
    }
}
