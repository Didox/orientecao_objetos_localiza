using System;

namespace strategy.Models.Implementado
{
    public interface ILegalCustomer : ICustomer
    {
        string Cnpj { get; set; }
        string RazaoSocial { get; set; }
    }
}
