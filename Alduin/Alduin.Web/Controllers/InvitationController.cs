using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alduin.Logic.Mediator.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Alduin.Logic.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Alduin.Logic.Mediator.Queries;

namespace Alduin.Web.Controllers
{
    public class InvitationController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IStringLocalizer<InvitationController> _localizer;
        private static Random random = new Random();
        private readonly UserManager<AppIdentityUser> _userManager;
        public InvitationController(IMediator mediator, IStringLocalizer<InvitationController> localizer, UserManager<AppIdentityUser> userManager)
        {
            _userManager = userManager;
            _mediator = mediator;
            _localizer = localizer;
        }
        public async Task<IActionResult> Index()
        {
            //var url = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            
            ViewData["Invitation"] = _localizer["Invitation"];
            ViewData["Generate new invitation"] = _localizer["Generate new invitation"];
            return View();
        }
        public async Task<IActionResult> GenerateNew()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            var key = RandomString(10);
            var InvitationCommand = new RegInvitationCommand
            {
                invitationKey = key,
                Used = false,
                UserId = user.Id
            };
            var result = await _mediator.Send(InvitationCommand);
            
            return Json(result);
        }
        public async Task<IActionResult> GetUserInvitation()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            var query = new GetInvitationByUserQuery { UserId = user.Id };
            var result = await _mediator.Send(query);
            return Json(result);
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
    
}