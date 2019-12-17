using FluentNHibernate.Cfg;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.IO;

namespace Alduin.DataAccess.Helpers
{
    public static class SqlScriptExporter
    {
        public static void ExportScripts(Configuration config, FluentConfiguration database)
        {
            var outputFolder = Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory)
                .Parent?.Parent?.Parent?.Parent?.FullName, "DB");

            if (Directory.Exists(outputFolder))
            {
                var script = new List<string>(config.GenerateSchemaUpdateScript(new PostgreSQL83Dialect(),
                    new DatabaseMetadata(database.BuildSessionFactory().OpenSession().Connection, new PostgreSQL83Dialect())));

                File.WriteAllText(Path.Combine(outputFolder, "_UpdateSchema.sql"), string.Join(";" + System.Environment.NewLine, script));

                script = new List<string>(config.GenerateSchemaCreationScript(new PostgreSQL83Dialect()));
                File.WriteAllText(Path.Combine(outputFolder, "_CreateSchema.sql"), string.Join(";" + System.Environment.NewLine, script));
            }
            else
            {
                Directory.CreateDirectory(outputFolder);
            }
        }
    }
}
