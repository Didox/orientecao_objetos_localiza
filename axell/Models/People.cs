using Newtonsoft.Json;

namespace Axell.Models
{
    public class People
    {
        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }
        protected string Name { get; set; }

        public People(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public virtual string Details()
        {
            return $"{{ \"name\": \"{Name}\" }}";
        }
    }
}
