using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Repositories.DataModel;
using Repositories.Interface;

namespace Repositories.Implement
{
    /// <summary>
    /// CombokindRepository
    /// </summary>
    /// <seealso cref="ICombokindRepository" />
    public class CombokindRepository : ICombokindRepository
    {
        public readonly string _connectionString;
        public readonly IDatabaseConstants _databaseConstants;

        /// <summary>
        /// Initializes a new instance of the <see cref="CombokindRepository" /> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="databaseConstants">The database constants.</param>
        public CombokindRepository(
            string connectionString,
            IDatabaseConstants databaseConstants)
        {
            this._connectionString = connectionString;
            this._databaseConstants = databaseConstants;
        }

        /// <summary>
        /// Gets the combokind data asynchronous.
        /// </summary>
        /// <param name="comboKind">Kind of the combo.</param>
        /// <returns></returns>
        public async Task<IEnumerable<CombokindDataModel>> GetCombokindDataAsync(string comboKind)
        {
            using (var conn = this._databaseConstants.GetConnection(this._connectionString))
            {
                var data = await conn.QueryAsync<CombokindDataModel>(
                    @"select * from ComboKind where ComboKind = @comboKind ",
                    new
                    {
                        comboKind = comboKind
                    });

                return data;
            }
        }
    }
}
