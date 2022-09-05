using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTest.Database.Repositories.Interfaces
{
    public interface ISqlRepository
    {
        Task<DataSet> GetByQuerySql(string query);
    }
}
