namespace Database
{
    public abstract class Dado : IBase
    {
        [Pk]
        public int id {get;set;}

       public abstract void Salvar();
    }
}