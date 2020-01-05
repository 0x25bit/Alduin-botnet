using Alduin.Logic.Identity;
using Alduin.Logic.Mediator.Commands;
using Alduin.Web.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;

namespace Alduin.Web.Controllers
{
    public class UserSettingsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IStringLocalizer<UserAccountController> _localizer;
        private readonly UserManager<AppIdentityUser> _userManager;

        public UserSettingsController(IMediator mediator, IStringLocalizer<UserAccountController> localizer, UserManager<AppIdentityUser> userManager)
        {
            _userManager = userManager;
            _mediator = mediator;
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            return RedirectToAction(nameof(ChangePassword));
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            var title = _localizer["Change Password"];
            SetTitle(title);
            ViewData["Change Password"] = title;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        {
            var title = _localizer["Change Password"];
            SetTitle(title);
            ViewData["Change Password"] = title;
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            return View(model);
        }
    }
}