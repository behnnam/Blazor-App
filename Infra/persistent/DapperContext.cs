using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Infra.persistent
{
    public class DapperContext
    {
        private IConfiguration _configoration;
        public DapperContext(IConfiguration configuration)
        {
            _configoration = configuration;
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(_configoration.GetConnectionString("DefaultConnection"));
    }
}

