using System.Threading.Tasks;
using TinySocial.DataAccess.Interfaces;

namespace TinySocial.DataAccess.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TinySocialContext _context;

        public UnitOfWork(TinySocialContext context)
        {
            _context = context;
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
