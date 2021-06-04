using SplittyTest.API.Persistence.Contexts;

namespace SplittyTest.API.Persistence.Repositories.Implementation
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}