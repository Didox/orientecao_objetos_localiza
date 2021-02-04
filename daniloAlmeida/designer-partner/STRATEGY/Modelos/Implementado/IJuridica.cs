using System;

namespace STRATEGY.Modelos.Implementado
{
    public interface IJuridica
    {
         string Cnpj{ get; set; }

        string RazaoSocial { get; set; }

        void Salvar(){ } 
    }
}