using System;

namespace Database.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ModelAttribute : Attribute
    {
        public string Table { get; set; }
    }
}
