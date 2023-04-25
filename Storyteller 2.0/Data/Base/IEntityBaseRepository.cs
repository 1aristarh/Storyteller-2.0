using Storyteller_2._0.Models;

namespace Storyteller_2._0.Data.Base
{
    public interface IEntityBaseRepository<T>where T: class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetbyIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}

