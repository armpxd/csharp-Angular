using System.ComponentModel.DataAnnotations;

namespace aspnetcore.Dtos
{
    public class UserForLoginDto
    {
        [Required]
        public string Username {get;set;}
        public string Password {get;set;}
    }
}