using System;

namespace STRATEGY.Modelos.Estrategia1
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string email { get; set; }

        public string Cpf { get; set; }

        public string Cnpj { get; set; }

        public string RazaoSocial { get; set; }

        public TipoCliente Tipo { get; set; }

        public void Salvar(){
            Console.WriteLine("Salvo no banco de dados");
        }
    }
}