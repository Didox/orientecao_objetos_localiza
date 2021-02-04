using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class FileService
    {

        public static bool Salvar<T>(T dado)
        {
            try
            {
                //Salvar objeto em arquivo
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
