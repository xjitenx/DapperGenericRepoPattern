using DapperGenericRepoPattern.DataContext;
using DapperGenericRepoPattern.Model;

namespace DapperGenericRepoPattern.Repository
{
    public class UserRepository: BaseRepository<User>
    {
        public UserRepository(DapperDataContext dapperDataContext) : base(dapperDataContext)
        {
        }
    }
}
