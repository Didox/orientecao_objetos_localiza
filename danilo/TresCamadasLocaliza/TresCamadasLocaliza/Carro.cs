using System;
using Database;

namespace Negocio
{
    [Tabela(Nome = "tbl_carros")]
    public class Carro : Dado
    {
        [CampoPersistido(NomeColuna = "nome_carro")]
        public string Nome { get; set; }

        [CampoPersistido]
        public string Telefone { get; set; }

        public int Ano { get; set; }

        public string Descricao { get; set; }

        public void Salvar()
        {
            CarroDbService.Salvar(this);
        }
    }
}
