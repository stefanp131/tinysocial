using System.Threading.Tasks;
using TinySocial.DataAccess.Entities;

namespace TinySocial.Services.Interfaces
{
    public interface ITokenGenerator
    {
        Task<string> CreateToken(AppUser user);
    }
}
