using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using SqlTest.Database.Repositories.Interfaces;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SqlTest.Database.Repositories
{
    public class SqlRepository : ISqlRepository
    {
        private readonly string cs;
        IConfiguration config;
        public SqlRepository(SqlDbContext context, IConfiguration configuration)
        {
            config = configuration;
            cs = config.GetConnectionString("SqlData");
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
        public string GetWithDapperSql(string query)
        {

            string result = "";

            using (var conn = new NpgsqlConnection(cs))
            {
                conn.Open();
                var temp = conn.Query(query);
                var list = temp.ToList();
                if (list.Any())
                {
                    foreach (var item in list)
                    {
                        result += $"{item} \n";
                    }
                }
            }

            return result;
        }
    }
}
