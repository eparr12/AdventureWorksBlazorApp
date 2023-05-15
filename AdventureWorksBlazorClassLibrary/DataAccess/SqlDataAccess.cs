using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AdventureWorksBlazorClassLibrary.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            this._config = config;
        }

        public async Task<List<T>> LoadData<T, U>(
            string storedProcedure,
            U parameters,
            string connectionId = "AdventureWorks2014")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
            var test = await connection.QueryAsync<T>(storedProcedure, parameters,
                commandType: CommandType.StoredProcedure);
            return test.ToList();
        }

        public async Task SaveData<T>(
           string storedProcedure,
            T parameters,
            string connectionId = "AdventureWorks2014")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            await connection.ExecuteAsync(storedProcedure, parameters,
                commandType: CommandType.StoredProcedure);
        }
    }
}
