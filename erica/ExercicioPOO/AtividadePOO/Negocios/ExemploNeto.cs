namespace Negocios
{
    public class ExemploNeto : ExemploFilho
    {
        
        public sealed abstract void SalvarSeladoNeto(){
            SalvarEx();
            Console.WriteLine("Salvar do neto.");
        }
    }
}