using System;

namespace Business.Modules.Client.Entities
{
    public interface IClient
    {
        int Id { get; set; }

        string Address { get; set; }

        int Number { get; set; }

        string City { get; set; }

        
    }
}