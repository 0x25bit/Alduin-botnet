using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using Alduin.Common.Attributes;

namespace Alduin.DataAccess.Conventions
{
    public class NotNullConvention : AttributePropertyConvention<NotNullAttribute>
    {
        protected override void Apply(NotNullAttribute attribute, IPropertyInstance instance)
        {
            instance.Not.Nullable();
        }
    }
}
