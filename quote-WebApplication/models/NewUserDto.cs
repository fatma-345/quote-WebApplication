using System.ComponentModel.DataAnnotations;

namespace quote_WebApplication.models
{
    public class NewUserDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
