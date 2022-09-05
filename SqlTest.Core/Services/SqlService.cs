using Npgsql;
using SqlTest.Core.Services.Interfaces;
using SqlTest.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTest.Core.Services
{
    public class SqlService:ISqlService
    {
        private readonly ISqlRepository _heroRepo;
        public SqlService(ISqlRepository heroRepo)
        {
            _heroRepo = heroRepo;
        }


        public async Task<string> GetSql(string query)
        {
            var dataSet = await _heroRepo.GetByQuerySql(query);

            var dataTable = dataSet.Tables[0];

            if (dataTable is null)
                throw new NpgsqlException("Неудалось найти таблицу");

            string result = "";

            foreach (DataRow dr in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    result += dataTable.Columns[i].ToString() + ": " + dr.ItemArray[i].ToString() + "\n";
                }

                result += "\n";
            }

            return result;
        }
    }
}
