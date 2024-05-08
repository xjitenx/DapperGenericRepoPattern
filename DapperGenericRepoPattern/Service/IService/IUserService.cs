using DapperGenericRepoPattern.Model;

namespace DapperGenericRepoPattern.Service.IService
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(Guid id);
        bool Insert(User user);
        bool Update(User user);
        bool Delete(Guid id);
    }
}
