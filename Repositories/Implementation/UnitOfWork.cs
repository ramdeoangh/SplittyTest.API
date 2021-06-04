using System.Threading.Tasks;
using SplittyTest.API.Repositories.Interface;
using SplittyTest.API.Persistence.Contexts;

namespace SplittyTest.API.Persistence.Repositories.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}