using System;

namespace Perfistencia.Infrastructure.Database
{
    public class PkAttribute : Attribute
    {
        public string Name {get;set;}
    }
}