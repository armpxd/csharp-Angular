using System.ComponentModel.DataAnnotations;

namespace aspnetcore.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage = "La Contraseña debe tener entre 4 a 8 caracteres")]
        public string Password { get; set; }
    }
}

