using System;

namespace strategy.Models.Implementado
{
    public class PhysicalCustomer : ICustomer, IPhysicalCustomer
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public void Save()
        {
            Console.WriteLine($"Salvando pessoa física, nome: {Nome}");
        }
    }
}
