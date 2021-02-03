using System;
namespace Interfaces
{
    public interface IVeiculo
    {
        string Marca { get; set; }
        string Nome { get; set; }
        int Ano { get; set; }

        void Salvar();
    }
}
