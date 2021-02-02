using System;
using System.Collections.Generic;
using System.Text;
using DataBase;

namespace Negocio
{
    public class NegocioService
    {

        public static void Salvar<T>(T dado)
        {
            DBServicesGenerics.Salvar(dado);
        }

        public static void Todos(IBase dado)
        {
            DBServicesGenerics.Salvar(dado);
        }
    }
}
