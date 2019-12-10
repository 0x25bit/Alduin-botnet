using Alduin.DataAccess.Entities.Base;
using System;

namespace Alduin.DataAccess.Entities
{
    public class RecordCategoryEntity : EntityBase
    {
        public virtual string Name { get; set; }

        public virtual RecordCategoryEntity ParentCategory { get; set; }

        public virtual DateTime? LastUsedUTC { get; set; }
    }
}
