using System.Collections.Generic;

namespace SqlTest.Database.Model
{
    public class Race : BaseEntity
    {
        //public List<Stat> BonusStats { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public ICollection<Hero> Hero { get; set; }

    }
}
