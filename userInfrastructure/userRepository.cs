using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userCore.Models;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace userApplication
{
    public class userRepository : IUsersRepository
    {

        private readonly IConfiguration _config;

        public userRepository(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<users>> getUsers(string queryString)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            var command = await connection.QueryAsync<users>(queryString);
            return (List<users>)command;

        }

    }
}
