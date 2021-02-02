using System;

namespace strategy.Models.Implementado
{
    public interface IPhysicalCustomer : ICustomer
    {
        string Cpf { get; set; }
    }
}
