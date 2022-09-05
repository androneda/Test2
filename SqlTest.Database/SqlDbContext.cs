using Microsoft.EntityFrameworkCore;
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
        public SqlDbContext([NotNull] DbContextOptions options) : base(options)
        {

        }
    }
}
