using Database.Attributes;

namespace Business.Models
{
    public partial class People
    {
        [Pk]
        public int Id { get; set; }
        [Column]
        public string Name { get; set; }

        public People(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public virtual string Details()
        {
            return $"{{ \"name\": \"{Name}\" }}";
        }
    }
}
