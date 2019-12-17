using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using Alduin.DataAccess.Conventions;
using Alduin.DataAccess.Entities.Base;
using Alduin.DataAccess.Helpers;

namespace Alduin.DataAccess.SessionBuilder
{
    public class SessionFactory
    {
        public static Configuration BuildConfiguration(string connectionString)
        {
            var config = Fluently.Configure();
            var dbConfig = PostgreSQLConfiguration.Standard.ConnectionString(connectionString)
                .FormatSql()
                .AdoNetBatchSize(100);

            var showSql = bool.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("ShowSql") ?? "false");
            if (showSql)
                dbConfig.ShowSql();

            config = config.Database(dbConfig);
            var cfg = SetMappings(config);

#if DEBUG
            SqlScriptExporter.ExportScripts(cfg, config);
#endif

            return cfg;
        }

        public static Configuration SetMappings(FluentConfiguration config)
        {
            config = config.Mappings(m => m.AutoMappings.Add(
                AutoMap.AssemblyOf<EntityBase>(new StoreConfiguration())
                    .IgnoreBase<EntityBase>()
                    .IgnoreBase<LogicalEntityBase>()
                    .Conventions.Add<CustomTableNameConvention>()
                    .Conventions.Add<CustomPropertyConvention>()
                    .Conventions.Add<TextConvention>()
                    .Conventions.Add<HasManyConvention>()
                    .Conventions.Add<ReferenceConvention>()
                    .Conventions.Add<PrimaryKeySequenceConvention>()
                    .Conventions.Add<NotNullConvention>()
            ));

            var cfg = config.BuildConfiguration();
            cfg.SetProperty("hbm2ddl.keywords", "auto-quote");

            return cfg;
        }
    }
}
