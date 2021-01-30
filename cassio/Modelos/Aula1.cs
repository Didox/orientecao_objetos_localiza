using cassio.Modelos;
using System;
using System.Collections.Generic;

namespace PrimeiraAulaCSharp
{
    public class Aula : BaseAula
    {
        private string _tema;

        private const string frasePadrao = "Um dos temas da aula foi: ";
        public string Tema
        {
            get
            {
                return String.Concat(frasePadrao, _tema);
            }
            set
            {
                _tema = value;
            }
        }
        public Aula(string tema) : base(tema)
        {
            _tema = tema;
        }

        public override void MostrarTemaAula()
        {
            Console.WriteLine(this.Tema);
        }

    }
}