using System.ComponentModel.DataAnnotations;

namespace SOLID.SRP.QuebrandoRegra
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Cpf { get; set; }

        public Cliente()
        {
        }

        public void Salvar()
        {
            if (!this.Validar == false) throw new System.Exception();

            // TO DO SALVAR REGISTRO
            System.Console.WriteLine("Registro Salvo");
        }

        public void Excluir()
        {
            // TO DO EXCLUIR REGISTRO
            System.Console.WriteLine("Registro Excluído");
        }

        public void EnviarSMS()
        {
            // TO DO ENVIAR SMS
            System.Console.WriteLine("Enviando SMS");
        }

        public bool Validar()
        {
            // TO DO VALIDAR DADOS
            System.Console.WriteLine("Validando Dados");
            return true;
        }
    }
}
