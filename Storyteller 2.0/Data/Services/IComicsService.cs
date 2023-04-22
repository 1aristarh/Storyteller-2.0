using Storyteller_2._0.Models;

namespace Storyteller_2._0.Data.Services
{
    public interface IComicsService
    {
        Task<IEnumerable<Comic>> GetAll();
        Comic GetbyId(int id);
        void Add(Comic comic);
        Comic Update(int id,Comic newComic);
        void Delete(int id);
    }
}
