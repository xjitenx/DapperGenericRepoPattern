using DapperGenericRepoPattern.Model;
using DapperGenericRepoPattern.Repository.IRepository;
using DapperGenericRepoPattern.Service.IService;

namespace DapperGenericRepoPattern.Service
{
    public class UserService: IUserService
    {
        private readonly IBaseRepository<User> _baseRepository;
        public UserService(IBaseRepository<User> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public List<User> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public User GetById(Guid id)
        {
            return _baseRepository.GetById(id);
        }

        public bool Insert(User user)
        {
            return _baseRepository.Insert(user);
        }

        public bool Update(User user)
        {
            return _baseRepository.Update(user);
        }

        public bool Delete(Guid id)
        {
            return _baseRepository.Delete(id);
        }
    }
}

