using System.Collections.Generic;

namespace MeuTeste
{
    public interface IPessoa
    {
        string Nome { get; set; }

        List<T> Listar<T>();

        void Salvar(Pessoa p);
    }
}
