using AutoMapper;
using NHibernate;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Managers;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.UnitOfWork;
using Alduin.Shared.Transaction;

namespace Alduin.Logic.Managers
{
    public class CreditCardManager : ManagerBase<CreditCardEntity, CreditCardDTO>, ICreditCardManager
    {
        public CreditCardManager(ISession session, IMapper mapper, IUnitOfWork unitOfWork) : base(session, mapper, unitOfWork)
        { }

        protected override TransactionResult ValidateSaving(CreditCardEntity entity)
        {
            var result = new TransactionResult
            {
                Succeeded = true
            };

            if (string.IsNullOrEmpty(entity.Name))
            {
                result.Succeeded = false;
                // TODO localization
                result.ErrorMessages.Add(new TransactionErrorMessage
                {
                    IsPublic = true,
                    Message = "Name is required!"
                });
            }

            return result;
        }
    }
}
