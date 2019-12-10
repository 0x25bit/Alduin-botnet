using Alduin.Shared.DTOs.Base;
using System;
using Alduin.Shared.Enums;

namespace Alduin.Shared.DTOs
{
    public class RecordDTO : DTOBase
    {
        public RecordCategoryDTO RecordCategory { get; set; }
        public int? RecordCategoryId { get; set; }

        public AccountDTO Account { get; set; }
        public int? AccountId { get; set; }

        public double Amount { get; set; }

        public Currency Currency { get; set; }

        public DateTime TransactionDateUTC { get; set; }
    }
}
