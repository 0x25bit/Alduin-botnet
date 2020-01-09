using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Alduin.Shared.DTOs;

namespace Alduin.Web.Models
{
    public class RegisterModel
    {
        public UserDTO User { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [DisplayName("Confirm password")]
        public string PasswordRe { get; set; }
        public string Key { get; set; }
    }
}
