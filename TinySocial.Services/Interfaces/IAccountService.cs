using System.Threading.Tasks;
using TinySocial.Services.DTOs;

namespace TinySocial.Services.Interfaces
{
    public interface IAccountService
    {
        Task<AccountDTO> LoginAsync(LoginDTO loginDto);
        Task<AccountDTO> RegisterAsync(RegisterDTO registerDto);
    }
}
