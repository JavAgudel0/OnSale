using System.ComponentModel.DataAnnotations;

namespace OnSale.Web.Models
{
    public class AddUserViewModel : EditUserViewModel
    {
        [Display(Name = "Email")]  //Lo que se muestra en pantalla
        [Required(ErrorMessage = "The field {0} is mandatory.")]  //Que el campo sea obligatorio
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")] //Que sea maximo de x caracteres
        [EmailAddress] //Que es direccion de telefono
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field must contain between {2} and {1} characters.")]
        public string Password { get; set; }

        [Display(Name = "Password Confirm")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field must contain between {2} and {1} characters.")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }

}
