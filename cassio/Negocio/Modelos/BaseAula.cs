using Database;

namespace Negocio.Modelos
{
    public class BaseAula : Ibase
    {
        public int Id { get; set; }
        public BaseAula(string Tema)
        {

        }
        public virtual void MostrarTemaAula()
        {
            
        }
    }
}
