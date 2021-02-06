using System;

namespace Perfistencia.Infrastructure.Database
{
    public class TableAttribute : Attribute
    {
        public string Name { get; set; }
    }
}