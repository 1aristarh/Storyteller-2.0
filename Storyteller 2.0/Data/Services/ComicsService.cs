using Microsoft.EntityFrameworkCore;
using Storyteller_2._0.Models;

namespace Storyteller_2._0.Data.Services
{
    public class ComicsService : IComicsService
    {
        private readonly AppDbContext _context;
        public ComicsService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Comic comic)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Comic>> GetAll()
        {
            var result = await _context.Comics.ToListAsync();
            return result;
        }

        public Comic GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public Comic Update(int id, Comic newComic)
        {
            throw new NotImplementedException();
        }
    }
}
