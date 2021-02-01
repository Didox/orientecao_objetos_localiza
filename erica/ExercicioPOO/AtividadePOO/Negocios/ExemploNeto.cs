namespace Negocios
{
    public sealed class ExemploNeto : ExemploFilho
    {
        
        public sealed override void SalvarSeladoNeto(){
           // base.SalvarFilho();
            base.SalvarEx();
            Console.WriteLine("Salvar do neto. - selado");
        }
    }
}