using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class NegocioService
    {

        public static bool Salvar<T>(T dado)
        {

            if (DBServiceGeneric.Salvar(dado) && FileService.Salvar(dado))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
