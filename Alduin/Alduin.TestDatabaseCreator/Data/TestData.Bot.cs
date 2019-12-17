using Alduin.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alduin.TestDatabaseCreator.Data
{
    internal static partial class TestData
    {
        internal static void CreateBots()
        {
        //BOTS
        var Bot1 = new BotEntity
        {
            UserName = "Bot1",
            KeyUnique = "asdasdasd",
            KeyCertified = "hash(asdasdasd+key)",
            LastLoggedInUTC = DateTime.UtcNow
        };
        InsertEntity(Bot1);
        }
        
    }
}
