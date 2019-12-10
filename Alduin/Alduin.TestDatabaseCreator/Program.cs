using Microsoft.Extensions.Configuration;
using NHibernate;
using System;
using System.Diagnostics;
using System.IO;
using Alduin.DataAccess.SessionBuilder;
using Alduin.TestDatabaseCreator.Data;

namespace Alduin.TestDataBaseCreator
{
    public static class Program
    {
        private static IConfigurationRoot _config;
        private static string _connectionString;

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Init();
        }

        public static void Init()
        {
            try
            {
                BuildConfig();
                _connectionString = _config.GetConnectionString("Alduin");

                Console.WriteLine("Recreating database...");
                RunRecreateScript();

                var configuration = SessionFactory.BuildConfiguration(_connectionString);

                var sessionFactory = configuration.BuildSessionFactory();
                using var session = sessionFactory.OpenSession();
                Console.WriteLine("Creating test data...");
                CreateTestData(session);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:");
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }

        private static void BuildConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .AddEnvironmentVariables();

            _config = builder.Build();
        }

        private static void RunRecreateScript()
        {
            var scriptPath = _config["RecreateDbCmd"];

            var pInfo = new ProcessStartInfo()
            {
                FileName = "recreate_db.cmd",
                UseShellExecute = true,
                WorkingDirectory = Path.GetDirectoryName(scriptPath)
            };

            var process = Process.Start(pInfo);
            process.WaitForExit();
            process.Close();
        }

        private static void CreateTestData(ISession session)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            using (var trans = session.BeginTransaction())
            {
                TestData.session = session;

                TestData.CreateCreditCards();
                TestData.CreateUsers();
                TestData.CreateAccounts();

                trans.Commit();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
