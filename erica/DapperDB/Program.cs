using System;
using Dapper;
using System.Data.SqlClient;
using System.IO;

namespace DapperDB
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            string _con = Configuration["ConnectionStrings:DefaultConnection"];
            Console.WriteLine("\tc - Consultar");
            Console.WriteLine("\ti - Incluir");
            Console.WriteLine("\ta - Atualizar");
            Console.WriteLine("\td - Deletar");
            Console.Write("Sua opção (c,i,d,a) ? ");
            switch (Console.ReadLine())
            {
                case "c":
                    Consultar(_con);
                    break;
                case "i":
                    Incluir(_con);
                    break;
                case "a":
                    Atualizar(_con);
                    break;
                case "d":
                    Deletar(_con);
                    break;
            }
            Console.ReadKey();*/
        }
    }
}
