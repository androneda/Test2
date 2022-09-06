using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTest.Core.Services.Interfaces
{
    public interface ISqlService
    {
        Task<string> GetSql(string query);
        string GetDapperSql();
    }
}
