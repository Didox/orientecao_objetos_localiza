using System.Collections.Generic;

using System;

namespace daniloAlmeida.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Id { get; set;}
        public TipoCliente Tipo { get; set;}
        
        public void SalvarBanco(){
            Console.WriteLine("salvo no banco");
        }

        public static List<Cliente> BuscarNoBanco(string nome = "teste"){
            return new List<Cliente>();
        }
       
    }
}