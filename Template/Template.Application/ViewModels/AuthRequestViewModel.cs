using System.ComponentModel.DataAnnotations;

namespace Template.Application.ViewModels
{
    public class AuthRequestViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
