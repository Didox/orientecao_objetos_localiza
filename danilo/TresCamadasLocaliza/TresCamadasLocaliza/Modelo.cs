using System;
using System.Collections.Generic;
using Database;

namespace Negocio
{
    [Tabela(Nome = "tbl_modelos")]
    public class Modelo
    {
        [CampoPersistido(NomeColuna = "nome_carro")]
        public string Nome { get; set; }


        public virtual void Salvar()
        {
            NegocioService.Salvar(this);
        }


        //public sealed string ToJson()
        //{
        //    return "Imagina que eu converti isso em uma string de json";
        //}
    }
}