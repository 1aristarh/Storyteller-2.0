using Storyteller_2._0.Models;

namespace Storyteller_2._0.Data.Services
{
    public interface IComicsService
    {
        Task<IEnumerable<Comic>> GetAllAsync();
        Task<Comic> GetbyIdAsync(int id);
        Task AddAsync(Comic comic);
        Task <Comic> UpdateAsync(int id,Comic newComic);
        Task DeleteAsync(int id);
    }
}
