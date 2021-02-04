using System;

namespace Michele.Models {
    public class Person {

        
        public int Id {get; set;}
        private string name;
        private string surname;


        public string Name {
            get
            {
                return name;
            }
        }

        public string Surname {
            get
            {
                return surname;
            }
        }

        public Person(){

        }

        public Person(string _name, string _surname)
        {
            name= _name;
            surname = _surname;
        }

        public virtual void WriteDisplay()
        {
            Console.WriteLine($"Metodo da classe pai, recebendo os parâmetros nome - {name}, e sobrenome - {surname}.");
        }
    }
}