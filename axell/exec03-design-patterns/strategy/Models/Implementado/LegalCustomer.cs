using System;

namespace strategy.Models.Implementado
{
    public class LegalCustomer : ICustomer, ILegalCustomer
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }

        public void Save()
        {
            Console.WriteLine($"Salvando pessoa jurídica, nome: {Nome}");
        }
    }
}
