using System;
using Dapper;
using System.Data.SqlClient;

namespace DapperDB
{
    class Program
    {
        static void Main(string[] args)
        {
           /* new Customer(){
            name = "Erica";
            email = "erica@email";
            phone = "3333-3333";
            CustomerType = 1;
            }*/

         new DapperDB<Customer>().Save(new Customer(){
                name = "Erica";
                email = "erica@email";
                phone = "3333-3333";
            });
    }
}
