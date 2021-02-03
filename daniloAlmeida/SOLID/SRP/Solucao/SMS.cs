namespace SRP.Solucao
{
    public class SMS
    {
         public void EnviarMSM(Cliente cliente, string msg){
            System.Console.WriteLine($"estouenviando a msg: {msg} para o cliente {cliente.Nome}");
        }
    }
}