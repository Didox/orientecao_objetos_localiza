using System;
using System.Collections.Generic;
using Database;

namespace Negocio
{
    [Tabela(Nome = "tbl_carros")]
    public partial class Carro : Dado
    {
        [CampoPersistido(NomeColuna = "nome_carro")]
        public string Nome { get; set; }

        [CampoPersistido]
        public string Telefone { get; set; }

        public int Ano { get; set; }

        public string Descricao { get; set; }

        public override void Salvar()
        {
            DbServiceGenerics.Salvar<Carro>(this);
        }

        public static List<Dado> Todos()
        {
            return CarroDbService.Todos(new Carro());
        }
    }
}