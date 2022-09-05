using System;

namespace SqlTest.Database.Model
{
    public class Session : BaseEntity
    {
        public Session()
        {

        }
        public Session(Guid userId, Guid roleId)
        {
            IsActive = true;
            UserId = userId;
            UserRoleId = roleId;
        }

        public bool IsActive { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid UserRoleId { get; set; }
        public Role UserRole { get; set; }
    }
}
