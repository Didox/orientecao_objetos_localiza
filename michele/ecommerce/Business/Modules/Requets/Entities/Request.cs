using System;
using Business.Modules.Client.Entities;
using Database.Attributes;

namespace Business.Modules.Requets.Entities
{
    public class Request
    {
        public int Id { get; set; }

        public IClient Client { get; set; }

        public double Total { get; set; }

        [OneToManyAttribute]
        public RequestProducts[] Products { get; set; }

    }
}