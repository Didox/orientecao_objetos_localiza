using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassio.Modelos
{
    public class BaseAula
    {
        protected int Id { get; set; }
        public BaseAula(string Tema)
        {
            
        }

        public virtual void MostrarTemaAula()
        {
           
        }
    }
}
