using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Alduin.Shared.DTOs;

namespace Alduin.Web.Models
{
    public class RegisterModel
    {
        [Display(Name = "Username")]
        [DisplayName("Username")]
        public UserDTO User { get; set; }

        [Display(Name = "E-mail")]
        [DisplayName("E-mail")]
        public UserDTO Email { get; set; }

        [Display(Name = "Password")]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [DisplayName("Confirm password")]
        public string PasswordRe { get; set; }
    }
}
