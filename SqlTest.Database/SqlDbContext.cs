using Microsoft.EntityFrameworkCore;
using SqlTest.Database.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTest.Database
{
    public class SqlDbContext: DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<Session> UserSessions { get; set; }
        public DbSet<User> Users { get; set; }

        public SqlDbContext([NotNull] DbContextOptions options) : base(options)
        {

        }
    }
}
