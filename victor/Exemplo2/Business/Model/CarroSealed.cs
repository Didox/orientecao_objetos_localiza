namespace Business.Model
{
    // Criação de classe com permissão SEALED
    public sealed class Hatch : Carro
    {
        public int QtdPortas { get; set; }

        // Sobrescrevendo Método utilizando new
        public new void Salvar()
        {
            System.Console.WriteLine("Salvando utilizando new");
            base.Salvar();
        }

        // Sobrescrevendo Método virtual utilizando override
        public override void SalvarVirtual()
        {
            System.Console.WriteLine("Salvando Partial Override");
            base.SalvarVirtual();
        }
    }
}