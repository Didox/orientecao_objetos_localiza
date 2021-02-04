using System;

namespace Database.Attributes
{
    public class PersistField : Attribute
    {
        public string Name { get; set; }        
        
    }
}