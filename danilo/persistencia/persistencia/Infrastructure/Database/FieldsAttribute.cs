using System;

namespace Perfistencia.Infrastructure.Database
{
    public class FieldsAttribute : Attribute
    {
        public string ColumnName { get; set; }
    }
}