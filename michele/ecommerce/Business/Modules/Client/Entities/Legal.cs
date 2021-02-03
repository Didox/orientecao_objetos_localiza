using System;

namespace Business.Modules.Client.Entities
{
    public class Legal : IClient
    {      
        public int Id { get; set; }

        public string Address { get; set; }

        public int Number { get; set; }

        public string City { get; set; } 
        public string CompanyName { get; set; }
        public string CNPJ { get; set; }
    }
}