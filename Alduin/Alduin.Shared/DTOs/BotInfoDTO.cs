using Alduin.Shared.DTOs.Base;

namespace Alduin.Shared.DTOs
{
    public class BotInfoDTO : DTOBase
    {
        public int? BotId { get; set; }
        public BotDTO Bot { get; set; }
        public string HardwareName { get; set; }
        public string HardwareType { get; set; }
        public string Performance { get; set; }
        public string OtherInformation { get; set; }
    }
}
