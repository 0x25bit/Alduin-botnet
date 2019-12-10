﻿using Alduin.Shared.DTOs;
using Alduin.DataAccess.Entities;
using Alduin.Shared.Interfaces.Managers;

namespace Alduin.Logic.Interfaces.Managers
{
    public interface ICreditCardManager : IManager<CreditCardEntity, CreditCardDTO>
    { }
}