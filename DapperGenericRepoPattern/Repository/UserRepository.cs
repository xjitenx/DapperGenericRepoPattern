using DapperGenericRepoPattern.DataContext;
using DapperGenericRepoPattern.Model;
using DapperGenericRepoPattern.Repository.IRepository;

namespace DapperGenericRepoPattern.Repository
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(IDapperDataContext dapperDataContext): base(dapperDataContext) { }
    }
}
