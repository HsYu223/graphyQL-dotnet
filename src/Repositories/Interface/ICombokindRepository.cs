using System.Collections.Generic;
using System.Threading.Tasks;
using Repositories.DataModel;

namespace Repositories.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICombokindRepository
    {
        Task<IEnumerable<CombokindDataModel>> GetCombokindDataAsync(string comboKind);
    }
}
