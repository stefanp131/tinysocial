using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TinySocial.Services.DTOs;
using TinySocial.Services.Exceptions;
using TinySocial.Services.Interfaces;

namespace TinySocial.API.Controllers
{
    public class AccountController : BaseAPIController
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AccountDTO>> Login(LoginDTO loginDto)
        {
            try
            {
                var accountDto = await _accountService.LoginAsync(loginDto);
                return Ok(accountDto);
            }
            catch (BadCredentialsException)
            {
                return Unauthorized("Wrong credentials");
            }
        }

        [HttpPost("register")]
        public async Task<ActionResult<AccountDTO>> Register(RegisterDTO registerDto)
        {
            try
            {
                var accountDto = await _accountService.RegisterAsync(registerDto);
                return Ok(accountDto);
            }
            catch (RegistrationFailed ex)
            {
                return BadRequest("RegistrationFailed " + ex.Message);
            }
        }
    }
}
