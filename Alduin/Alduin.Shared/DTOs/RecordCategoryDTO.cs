using Alduin.Shared.DTOs.Base;
using System;

namespace Alduin.Shared.DTOs
{
    public class RecordCategoryDTO : DTOBase
    {
        public string Name { get; set; }

        public int? ParentCategoryId { get; set; }

        public RecordCategoryDTO ParentCategory { get; set; }

        public DateTime? LastUsedUTC { get; set; }
    }
}
