using System;
using System.Collections.Generic;

namespace PrimeiraAulaCSharp
{
    public class Aula
    {

        public int Id { get; set; }
        private string tema;
        private const string frasePadrao = "Um dos temas da aula foi: ";
        public string Tema
        {
            get
            {
                return String.Concat(frasePadrao, this.tema);
            }
            set
            {
                this.tema = value;
            }
        }

    }
}