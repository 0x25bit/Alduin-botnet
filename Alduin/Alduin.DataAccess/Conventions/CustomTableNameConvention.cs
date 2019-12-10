using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using System.Globalization;
using Alduin.DataAccess.Helpers;

namespace Alduin.DataAccess.Conventions
{
    public class CustomTableNameConvention : IClassConvention
    {
        public void Apply(IClassInstance instance)
        {
            instance.Table(string.Format(CultureInfo.InvariantCulture, "{0}", NameConverter.ConvertName(instance.EntityType.Name)));
        }
    }
}
