using DapperGenericRepoPattern.Model;

namespace DapperGenericRepoPattern.Repository.IRepository
{
    public interface IBaseRepository<T> where T : IDbEntity
    {
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
    }
}
