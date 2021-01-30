using System;
    public class Conta
    {

       protected int Agencia {get; set;}
       private int Banco {get; set;}
       public string Observacao {get; set;}

 
       public virtual void Depositar()
       {
           Console.WriteLine("Deposito classe pai: " + Banco);
       }

    }