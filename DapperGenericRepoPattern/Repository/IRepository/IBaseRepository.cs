using DapperGenericRepoPattern.Model;

namespace DapperGenericRepoPattern.Repository.IRepository
{
    public interface IBaseRepository<T> where T : IDbEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
