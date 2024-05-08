using DapperGenericRepoPattern.Model;

namespace DapperGenericRepoPattern.Service.IService
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(Guid id);
        Task<bool> Add(User user);
        Task<bool> Update(User user);
        Task<bool> Delete(User user);
    }
}
