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

        public async Task AddAsync(Comic comic)
        {
           await _context.Comics.AddAsync(comic);
           await  _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Comics.FirstOrDefaultAsync(n => n.Id == id);
            _context.Comics.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Comic>> GetAllAsync()
        {
            var result = await _context.Comics.ToListAsync();
            return result;
        }

        public async Task<Comic> GetbyIdAsync(int id)
        {
            var result = await _context.Comics.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Comic> UpdateAsync(int id, Comic newComic)
        {
            _context.Update(newComic);
                await _context.SaveChangesAsync();
            return newComic;
        }
    }
}
