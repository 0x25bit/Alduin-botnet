using Alduin.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alduin.TestDatabaseCreator.Data
{
    internal static partial class TestData
    {
        internal static void CreateBots()
        {   //BOTS
            var Bot1 = new BotEntity
            {
                UserName = "Bot1",
                Domain = "fsdfsdfsdf.onion",
                LastIPAddress = "10.0.0.1",
                CountryCode = "HU",
                KeyUnique = "asdasdasd",
                KeyCertified = "hash(asdasdasd+key)",
                LastLoggedInUTC = DateTime.UtcNow
            };
            InsertEntity(Bot1);
            var Bot2 = new BotEntity
            {
                UserName = "Bot2",
                Domain = "asdasdasd.onion",
                LastIPAddress = "10.0.0.2",
                CountryCode = "RU",
                KeyUnique = "asdasdasdqwe",
                KeyCertified = "hash(asdasdasdqwe+key)",
                LastLoggedInUTC = DateTime.UtcNow
            };
            InsertEntity(Bot2);
        }
    }
}
