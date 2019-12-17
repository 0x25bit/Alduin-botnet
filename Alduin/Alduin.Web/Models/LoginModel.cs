using System.ComponentModel.DataAnnotations;
namespace Alduin.Web.Models
{
    public class LoginModel
    {
        // TODO localization
        //[DisplayName("E-mail")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        //[DisplayName("Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //[DisplayName("Remember me")]
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
