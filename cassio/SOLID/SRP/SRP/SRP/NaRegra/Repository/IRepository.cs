using SRP.NaRegra.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.NaRegra.Repository
{
    public interface IRepository 
    {
        public void Salvar<T>(T obj);
    }
}
