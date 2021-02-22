using System.Data;

namespace Repositories.Interface
{
    /// <summary>
    /// Database Constants
    /// </summary>
    public interface IDatabaseConstants
    {
        /// <summary>
        /// 建立連線
        /// </summary>
        IDbConnection GetConnection(string connectionString);
    }
}
