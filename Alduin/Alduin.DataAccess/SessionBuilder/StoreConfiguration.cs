using FluentNHibernate;
using FluentNHibernate.Automapping;
using System;
using Alduin.DataAccess.Entities.Base;
using Alduin.DataAccess.Helpers;

namespace Alduin.DataAccess.SessionBuilder
{
    public class StoreConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.IsSubclassOf(typeof(EntityBase));
        }

        public override string GetComponentColumnPrefix(Member member)
        {
            var result = NameConverter.ConvertName(member.Name) + "_";
            return result;
        }
    }
}
