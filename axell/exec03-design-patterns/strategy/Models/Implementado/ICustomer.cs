using System;

namespace strategy.Models.Implementado
{
    public interface ICustomer
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Telefone { get; set; }
        string Email { get; set; }

        void Save();
    }
}
