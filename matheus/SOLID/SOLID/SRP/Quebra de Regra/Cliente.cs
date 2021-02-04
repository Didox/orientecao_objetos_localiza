using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.Quebra_de_Regra
{
    public class Cliente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }

        public bool EnviaSMS()
        {
            //Envia SMS
            return true;
        }

        public bool Salvar()
        {
            //Salva no banco
            return true;
        }

        public bool Validar()
        {
            //Valida Cliente
            return true;
        }
    }


   
}
