using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.AcceptanceCriteria;
using FluentNHibernate.Conventions.Inspections;
using FluentNHibernate.Conventions.Instances;
using System.Globalization;
using Alduin.DataAccess.Helpers;

namespace Alduin.DataAccess.Conventions
{
    public class CustomPropertyConvention : IPropertyConvention, IPropertyConventionAcceptance
    {
        public static string ConvertToCustomName(string propertyName)
        {
            var result = string.Format(CultureInfo.InvariantCulture, "{0}", NameConverter.ConvertName(propertyName));
            return result;
        }

        public void Apply(IPropertyInstance instance)
        {
            instance.Column(ConvertToCustomName(instance.Property.Name));
        }

        public void Accept(IAcceptanceCriteria<IPropertyInspector> criteria)
        {
            criteria.Expect(x => x.Formula == null);
        }
    }
}
