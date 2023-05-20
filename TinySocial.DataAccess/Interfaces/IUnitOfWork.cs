using System.Threading.Tasks;

namespace TinySocial.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> Complete();
    }
}
