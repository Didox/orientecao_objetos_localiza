namespace Business.Model
{
    // Criando Partial Class
    public partial class Carro
    {
        // Criando Método
        public void Salvar(){
            System.Console.WriteLine("Salvando Partial Class");
        }

        // Criando Método Virtual
        public virtual void SalvarVirtual(){
            System.Console.WriteLine("Salvando Partial Virtual");
        }
    }
}