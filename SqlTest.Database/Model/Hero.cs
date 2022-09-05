using System;

namespace SqlTest.Database.Model
{
    public class Hero : Character
    {
        public string Name { get; set; }

        public Guid RaceId { get; set; }
        public Guid SpecializationId { get; set; }
        public Race Race { get; set; }
        public Specialization Specialization { get; set; }
        public int Level { get; set; }
        public int ActionPoints { get; set; }

        //public List<Skill> Skills { get; set; }   
        //public List<Stat> Stats { get; set; }

        public Guid HeadId { get; set; }
        public Guid BodyId { get; set; }

        public Guid WeaponId { get; set; }
        public Guid HelmetId { get; set; }
        public Guid SecondWeaponId { get; set; }

        public bool Sex { get; set; }
        public bool IsDead { get; set; }
        public bool ShowHelmet { get; set; }
    }
}
