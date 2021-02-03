using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class DBServiceGeneric
    {

        public static bool Salvar<T>(T dado)
        {
            try
            {
                //Salvar objeto no banco de dados
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
    
        }

    }
}
