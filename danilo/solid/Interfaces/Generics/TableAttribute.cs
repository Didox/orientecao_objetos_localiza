using System;
namespace Interfaces.Generics
{
    public class TableAttribute : Attribute
    {
        public string Name { set; get; }
        public string PrimaryKey { set; get; }
        public string Collection { set; get; }
        public string ForeignKey { set; get; }
        public bool IsNotOnDataBase { set; get; }
    }
}
