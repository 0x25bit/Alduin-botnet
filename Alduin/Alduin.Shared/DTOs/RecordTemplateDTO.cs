using Alduin.Shared.DTOs.Base;

namespace Alduin.Shared.DTOs
{
    public class RecordTemplateDTO : DTOBase
    {
        public string Name { get; set; }
        public RecordCategoryDTO RecordCategory { get; set; }
        public AccountDTO Account { get; set; }
        public int? AccountId { get; set; }
        public int? RecordCategoryId { get; set; }
        public double Amount { get; set; }
    }
}
