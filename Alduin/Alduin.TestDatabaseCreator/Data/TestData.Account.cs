using Alduin.DataAccess.Entities;
using Alduin.Shared.Enums;

namespace Alduin.TestDatabaseCreator.Data
{
    internal static partial class TestData
    {
        internal static void CreateAccounts()
        {
            var user1 = session.Load<UserEntity>(1);

            var account1 = new AccountEntity
            {
                Name = "Credit Card Account",
                Balance = 20000,
                AccountType = AccountType.CreditCard,
                Currency = Currency.HUF,
                User = user1
            };
            InsertEntity(account1);

            var account2 = new AccountEntity
            {
                Name = "Credit Card Account",
                Balance = 3450,
                AccountType = AccountType.Cash,
                Currency = Currency.HUF,
                User = user1
            };
            InsertEntity(account2);
        }
    }
}
