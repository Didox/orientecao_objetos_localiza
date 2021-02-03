namespace SRP.Solucao
{
    public class Repositorio
    {
        public static void Salvar(Cliente cliente)
        {
            var ok = Validacao.Validar(cliente.Id);
            if (ok){
                System.Console.WriteLine($"estou salvando o cliente: {cliente.Nome}");
            }
            else{
                System.Console.WriteLine($"Erro!!! não salvei o cliente: {cliente.Nome}");
            }
            
        }
        public void Excluir(Cliente cliente){
            System.Console.WriteLine($"estou excluindo o cliete {cliente.Nome}");
        }

        public void Alterar(Cliente cliente){
            System.Console.WriteLine($"estou Alterando o cliete {cliente.Nome}");
        }

        
    }
}