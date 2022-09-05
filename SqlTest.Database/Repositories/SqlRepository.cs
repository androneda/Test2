using Npgsql;
using SqlTest.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SqlTest.Database.Repositories
{
    public class SqlRepository:ISqlRepository
    {
        private readonly string cs;
        IConfiguration config;
        public SqlRepository(SqlDbContext context, IConfiguration configuration)
        {
            config = configuration;
            cs = config.GetConnectionString("WebGameData");
        }

        public async Task<DataSet> GetByQuerySql(string query)
        {
            using var con = new NpgsqlConnection(cs);
            con.Open();
            using var command = new NpgsqlCommand(query, con);

            await command.PrepareAsync();

            DataSet dataSet = new DataSet();

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);

            dataAdapter.Fill(dataSet);

            return dataSet;
        }
    }
}
