using System;


namespace SqlTest.Database.Model
{
    public class Skill : BaseEntity
    {
        public string Name { get; set; }
        public string BaseStat { get; set; }
        public int? Status { get; set; }
        public int? Range { get; set; }
        public Guid? TargetId { get; set; }
        public int? RechargeTime { get; set; }
        public int? CostActionPoints { get; set; }
        public int? DamageRadius { get; set; }
        public int? BonusActionPoints { get; set; }
        public bool? IsOnAlly { get; set; }

        public Guid? RaceId { get; set; }
        public Guid? SpecializationId { get; set; }

        //Level
    }
}
