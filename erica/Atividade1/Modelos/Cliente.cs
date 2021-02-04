using System;

namespace erica.Modelos
{
    public class Cliente
    {
        private string nome;
        public int id {get;set;}

        public string Nome{
            get{
                return this.nome;
            }

            set{
                this.nome = value.ToUpper();
            }
        }

        public void Salvar()
        {
          Console.WriteLine("Cliente salvo com sucesso!");
        }
    }
}