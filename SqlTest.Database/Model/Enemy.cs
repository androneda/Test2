using System;

namespace SqlTest.Database.Model
{
    public class Enemy : Character
    {
        public string Name { get; set; }
        public string ImagePng { get; set; }
        public bool IsRanged { get; set; }
        public Guid RaceId { get; set; }
        public Guid SpecializationId { get; set; }
    }
}
