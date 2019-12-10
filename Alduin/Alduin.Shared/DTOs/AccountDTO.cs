using Alduin.Shared.DTOs.Base;
using System.ComponentModel;
using Alduin.Shared.Enums;

namespace Alduin.Shared.DTOs
{
    public class AccountDTO : DTOBase
    {
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Balance")]
        public double Balance { get; set; }

        [DisplayName("Type")]
        public AccountType AccountType { get; set; }

        [DisplayName("Currency")]
        public Currency Currency { get; set; }

        public int? UserId { get; set; }

        public UserDTO User { get; set; }
    }
}
