using System;
using System.Collections.Generic;

namespace Interfaces
{
    public abstract class Carro
    {
        public string Marca { get; set; }
        public string Roda { get; set; }
        public string Porta { get; set; }
        public string Vidro { get; set; }

        public List<Carro> Todos()
        {
            return new List<Carro>(); 
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }

        public abstract void Salvar();

        public abstract List<Carro> BuscaPorNome(string nome);
    }
}
