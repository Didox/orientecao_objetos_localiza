using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public abstract class Cliente : IBase
    {
        public int Id { get; set; }
        public string Endereco { get; set; }

        public virtual void Salvar()
        {
            ClienteDBService.Salvar(this);
        }
        
    }
}
