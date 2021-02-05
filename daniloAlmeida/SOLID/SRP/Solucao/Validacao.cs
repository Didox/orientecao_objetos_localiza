namespace SRP.Solucao
{
    public class Validacao
    {
        public static bool Validar(int id)
        {
            System.Console.WriteLine("estou validando o cliente");
            if (id > 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}