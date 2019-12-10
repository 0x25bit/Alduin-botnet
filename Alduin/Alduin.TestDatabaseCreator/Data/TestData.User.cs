using System;
using System.Security.Claims;
using Alduin.DataAccess.Entities;
using Alduin.Shared.Enums;

namespace Alduin.TestDatabaseCreator.Data
{
    static partial class TestData
    {
        internal static void CreateUsers()
        {
            var user1 = new UserEntity
            {
                Name = "Test User",
                Email = "user@test.com",
                UserName = "user@test.com",
                NormalizedUserName = "USER@TEST.COM",
                PasswordHash = "AQAAAAEAACcQAAAAEEwE0nJJF+kuPBI1Qhn99jS0aLcxbDmWLdpUfWO/h31PVOCeUlW2n4z4Mnkp80fcdw==", // 12345
                SecurityStamp = "Y2HA3UVELZRLEOJ4L7TO5MRFGX5WLRBI",
                CreationDateUTC = DateTime.UtcNow,
                ModificationDateUTC = DateTime.UtcNow,
                IsDeleted = false
            };
            InsertEntity(user1);

            var user2 = new UserEntity
            {
                Name = "Test Admin",
                Email = "admin@test.com",
                UserName = "admin@test.com",
                NormalizedUserName = "ADMIN@TEST.COM",
                PasswordHash = "AQAAAAEAACcQAAAAEEwE0nJJF+kuPBI1Qhn99jS0aLcxbDmWLdpUfWO/h31PVOCeUlW2n4z4Mnkp80fcdw==", // 12345
                SecurityStamp = "Y2HA3UVELZRLEOJ4L7TO5MRFGX5WLRBI",
                CreationDateUTC = DateTime.UtcNow,
                ModificationDateUTC = DateTime.UtcNow,
                IsDeleted = false
            };
            InsertEntity(user2);

            // UserClaims
            var user1Claims = new[]
            {
                new UserClaimEntity
                {
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = Role.User.ToString(),
                    CreationDateUTC = DateTime.UtcNow,
                    ModificationDateUTC = DateTime.UtcNow,
                    User = user1
                },
                new UserClaimEntity
                {
                    ClaimType = "UserId",
                    ClaimValue = user1.Id.ToString(),
                    CreationDateUTC = DateTime.UtcNow,
                    ModificationDateUTC = DateTime.UtcNow,
                    User = user1
                }
            };
            foreach (var userClaim in user1Claims)
                InsertEntity(userClaim);

            var user2Claims = new[]
            {
                new UserClaimEntity
                {
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = Role.Admin.ToString(),
                    CreationDateUTC = DateTime.UtcNow,
                    ModificationDateUTC = DateTime.UtcNow,
                    User = user2
                },
                new UserClaimEntity
                {
                    ClaimType = "UserId",
                    ClaimValue = user2.Id.ToString(),
                    CreationDateUTC = DateTime.UtcNow,
                    ModificationDateUTC = DateTime.UtcNow,
                    User = user2
                }
            };
            foreach (var userClaim in user2Claims)
                InsertEntity(userClaim);
        }
    }
}
