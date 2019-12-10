using Alduin.Shared.DTOs.Base;

namespace Alduin.Shared.DTOs
{
    public class UserClaimDTO : DTOBase
    {
        public int? UserId { get; set; }

        public UserDTO User { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }
    }
}
