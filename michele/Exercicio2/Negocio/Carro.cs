using DataBase;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negocio
{
    [Tabela(Nome = "tbl_carro")]
    public class Carro : IBase
    {
        public int Id { get; set; }

        [CampoPersisitidoAttribute(NomeColuna ="descricao_carro")]
        public string Descricao { get; set; }

        [CampoPersisitidoAttribute]
        public string Cor { get; set; }

        [CampoPersisitidoAttribute]
        public int Ano { get; set; }

    }
}
