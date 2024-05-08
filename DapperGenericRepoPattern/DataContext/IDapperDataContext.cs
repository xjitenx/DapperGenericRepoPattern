using System.Data;

namespace DapperGenericRepoPattern.DataContext
{
    public interface IDapperDataContext
    {
        public IDbConnection? Connection { get; }
    }
}
