namespace Database
{
    public abstract class Dado : IBase
    {
        [Pk]
        public int Id { get; set; }

        public abstract void Salvar();
    }
}