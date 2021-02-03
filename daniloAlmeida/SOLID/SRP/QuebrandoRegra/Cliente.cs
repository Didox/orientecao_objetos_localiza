namespace SRP.QuebrandoRegra
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }


        public void Salvar()
        {
            System.Console.WriteLine("estou salvando o cliente");
        }
        public bool Validar(int id)
        {
            System.Console.WriteLine("estou validando o cliente");
            if (id > 1)
            {
                return true;
            }
            else
            {
                return true;
            }

        }

        public void EnviarMSM(Cliente cliente, string msg){
            System.Console.WriteLine($"estouenviando a msg: {msg} para o cliente {cliente.Nome}");
        }
        
        public Cliente Buscar(){
            System.Console.WriteLine("estou buscando o cliente");
            return new Cliente();
        }
        public void Excluir(Cliente cliente){
            System.Console.WriteLine($"estou excluindo o cliete {cliente.Nome}");
        }
    }
}