using Alduin.Shared.DTOs.Base;

namespace Alduin.Shared.DTOs
{
    public class InvitationDTO : DTOBase
    {
        public int? UserId { get; set; }
        public string invitationKey { get; set; }
        public UserDTO User { get; set; }
        public bool Used { get; set; }
    }
}
