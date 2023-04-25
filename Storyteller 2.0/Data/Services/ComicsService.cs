using Microsoft.EntityFrameworkCore;
using Storyteller_2._0.Data.Base;
using Storyteller_2._0.Models;

namespace Storyteller_2._0.Data.Services
{
    public class ComicsService : EntityBaseRepositoty<Comic>, IComicsService
    {

        public ComicsService(AppDbContext context) : base(context) { }

        
    }
}
