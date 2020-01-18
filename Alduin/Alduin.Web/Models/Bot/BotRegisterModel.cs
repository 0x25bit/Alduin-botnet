using System.ComponentModel.DataAnnotations;

namespace Alduin.Web.Models.Bot
{
    public class BotRegisterModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string KeyUnique { get; set; }
        [Required]
        public string KeyCertified { get; set;}
        [Required]
        public string Domain { get; set; }
        [Required]
        public string LastIPAddress { get; set; }
    }
}
