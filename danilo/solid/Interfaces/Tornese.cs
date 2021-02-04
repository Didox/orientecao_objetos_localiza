using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class Tornese : Carro
    {
        public Tornese()
        {
            this.Marca = "Tornese";
        }

        public override void Salvar()
        {
            //base.Salvar();
            Console.WriteLine($"Um novo comportamento para esta ação na marca {this.Marca}");
        }

        public new void Excluir()
        {
            base.Excluir();
            Console.WriteLine("Ação2 para excluir dados");
        }

        public override List<Carro> BuscaPorNome(string nome)
        {
            throw new NotImplementedException();
        }

    }
}
