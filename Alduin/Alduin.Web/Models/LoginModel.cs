using System.ComponentModel;

namespace Alduin.Web.Models
{
    public class LoginModel
    {
        // TODO localization
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Remember me")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
