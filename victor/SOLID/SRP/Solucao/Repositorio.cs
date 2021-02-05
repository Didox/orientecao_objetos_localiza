namespace SOLID.SRP.Solucao
{
    public class Repositorio
    {
        public void Salvar(Cliente cliente)
        {
            var validar = new Validacao();
            validar.ValidarCliente (cliente);
            // TO DO Salvar o Cliente
            System.Console.WriteLine("O Cliente foi salvo com sucesso!");
        }

        public void Excluir(Cliente cliente)
        {
            // TO DO Excluir o cliente
            System.Console.WriteLine("O Cliente foi excluído com sucesso!");
        }
    }
}
