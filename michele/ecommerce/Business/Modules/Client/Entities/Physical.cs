using System;

namespace Business.Modules.Client.Entities
{
    public class Physical : IClient
    {        
        public int Id { get; set; }

        public string Address { get; set; }

        public int Number { get; set; }

        public string City { get; set; }

        public string Cpf { get; set; }
        
        public string Name { get; set; }
    }
}