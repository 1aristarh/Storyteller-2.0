using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Storyteller_2._0.Data;

namespace Storyteller_2._0.Controllers
{
    public class ComicsController : Controller
    {
        private readonly AppDbContext _context;
        public ComicsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Comics.ToListAsync();
            return View(data);
        }
    }
}
