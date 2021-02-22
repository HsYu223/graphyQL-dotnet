using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Repositories.Interface;

namespace Repositories.Implement
{
    public class DatabaseConstants : IDatabaseConstants
    {
        /// <summary>
        /// 建立連線
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public IDbConnection GetConnection(string connectionString)
        {
            var conn = new SqlConnection(connectionString);

            return conn;
        }
    }
}
