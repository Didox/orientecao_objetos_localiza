using System;
    public class ContaCorrente : Conta
    {
        
        public ContaCorrente(int Agencia)
        {
            this.Agencia = Agencia;
        }

        public override void Depositar()
       {
             Console.WriteLine("Deposito classe filha.");
             //base.Depositar();
       }

    }