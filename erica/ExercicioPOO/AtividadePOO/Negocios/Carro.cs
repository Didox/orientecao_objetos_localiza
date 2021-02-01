using System;
using System.Collections.Generic;
using Database;

namespace Negocio
{
    [Tabela(Nome = "tbl_carros")]
    public class Carro : Dado
    {
        [CampoPersistido(NomeColuna = "nome_carro")]
        public string Nome { get; set; }

        [CampoPersistido]
        public int Ano { get; set; }

        public string Descricao { get; set; }

       /* public void Salvar()
        {
            CarroDBService.Salvar(this);
        }*/

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
