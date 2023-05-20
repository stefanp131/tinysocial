using System.ComponentModel.DataAnnotations;

namespace TinySocial.Services.DTOs
{
    public class RegisterDTO
    {
        [Required] public string Username { get; set; }

        [Required]
        [MinLength(4)]
        public string Password { get; set; }
    }
}
