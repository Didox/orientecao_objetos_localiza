using Database.Attributes;

namespace Business.Models
{
    public partial class People
    {
        public virtual int MyId()
        {
            return Id;
        }
    }
}
