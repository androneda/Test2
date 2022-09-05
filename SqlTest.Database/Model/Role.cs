using System.Collections.Generic;

namespace SqlTest.Database.Model
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
