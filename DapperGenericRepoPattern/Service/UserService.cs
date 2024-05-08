using DapperGenericRepoPattern.Model;
using DapperGenericRepoPattern.Repository.IRepository;
using DapperGenericRepoPattern.Service.IService;

namespace DapperGenericRepoPattern.Service
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _userRepository.GetAll();
        }

        public async Task<User> GetById(Guid id)
        {
            return await _userRepository.GetById(id);
        }

        public async Task<bool> Add(User user)
        {
            return await _userRepository.Add(user);
        }

        public async Task<bool> Update(User user)
        {
            return await _userRepository.Update(user);
        }

        public async Task<bool> Delete(User user)
        {
            return await _userRepository.Delete(user);
        }
    }
}

