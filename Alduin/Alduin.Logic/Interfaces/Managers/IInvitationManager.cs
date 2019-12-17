using Alduin.DataAccess.Entities;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alduin.Logic.Interfaces.Managers
{
    public interface IInvitationManager : IManager<InvitationEntity, InvitationDTO>
    {
    }
}
