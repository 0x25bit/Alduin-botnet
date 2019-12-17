using Alduin.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alduin.TestDatabaseCreator.Data
{
    internal static partial class TestData
    {
        internal static void CreateInvitation()
        {
            var user1 = session.Load<UserEntity>(1);
            var Invitation = new InvitationEntity
            {
                invitationKey = "Key",
                User = user1,
                Used = false
            };
            InsertEntity(Invitation);
        }

    }
}