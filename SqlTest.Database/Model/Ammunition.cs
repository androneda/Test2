using System;

namespace SqlTest.Database.Model
{
    public class Ammunition : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public Guid RaceId { get; set; }
        public Guid SpecializationId { get; set; }

    }
}
