using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using Alduin.Common.Attributes;

namespace Alduin.DataAccess.Conventions
{
    public class TextConvention : AttributePropertyConvention<TextAttribute>
    {
        protected override void Apply(TextAttribute attribute, IPropertyInstance instance)
        {
            var maxLength = attribute.MaxLength;

            if (instance.Property.PropertyType == typeof(string) && maxLength == int.MaxValue)
            {
                instance.CustomSqlType("text");
            }
            else
            {
                instance.Length(maxLength);
            }
        }
    }
}
