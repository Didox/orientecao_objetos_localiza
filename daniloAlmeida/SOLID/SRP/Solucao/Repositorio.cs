namespace SRP.Solucao
{
    public class Repositorio
    {
        public void Salvar()
        {
            var ok = Validacao.Validar(2);
            if (ok){
                System.Console.WriteLine("estou salvando o cliente");
            }
            else{
                System.Console.WriteLine("Erro não salvei cliente");
            }
            
        }
    }
}