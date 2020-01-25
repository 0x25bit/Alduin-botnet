using Alduin.DataAccess.Entities.Base;

namespace Alduin.DataAccess.Entities
{
    public class BotInfoEntity : EntityBase
    {
        public virtual BotEntity Bot { get; set; }
        public virtual string HardwareName { get; set; }
        public virtual string HardwareType { get; set; }
        public virtual string Performance { get; set; }
        public virtual string OtherInformation { get; set; }
    }
}
