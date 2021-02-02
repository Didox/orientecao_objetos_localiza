using System;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
           new Cliente(){
             nome = "Erica";
             cpf = "1234";
             telefone = "1234";
             email = "erica@email";
           }.Salvar();
        }
    }
}
