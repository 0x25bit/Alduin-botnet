using Alduin.Web.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using Alduin.Logic.Mediator.Commands;
using Alduin.Logic.Mediator.Queries;
using Alduin.Web.Models;

namespace Alduin.Web.Controllers
{
    public class UserAccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IStringLocalizer<UserAccountController> _localizer;

        public UserAccountController(IMediator mediator, IStringLocalizer<UserAccountController> localizer)
        {
            _mediator = mediator;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            var title = _localizer["Login"];
            SetTitle(title);

            var model = new LoginModel
            {
                ReturnUrl = returnUrl ?? Url.Content("~/")
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            SetTitle("Login");

            if (!ModelState.IsValid)
                return View(model);

            var loginCommand = new LoginCommand
            {
                Email = model.Email,
                Password = model.Password,
                RememberMe = model.RememberMe
            };
            var result = await _mediator.Send(loginCommand);

            if (!result.Suceeded)
            {
                foreach (var msg in result.ErrorMessages)
                    ModelState.AddModelError("", _localizer[msg]);

                return View(model);
            }

            return LocalRedirect(model.ReturnUrl ?? "");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _mediator.Send(new LogoutCommand());
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        public IActionResult ForgotPassword()
        {
            // TODO finish
            return Json("WIP");
        }

        public IActionResult ChangePassword()
        {
            // TODO finish
            return Json("WIP");
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            SetTitle("Registration");
            await FillIdentityOptionsViewBag();

            var model = new RegisterModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            SetTitle("Registration");
            await FillIdentityOptionsViewBag();

            if (!ModelState.IsValid)
                return View(model);

            var registerCommand = new RegisterCommand
            {
                User = model.User,
                Password = model.Password
            };
            var result = await _mediator.Send(registerCommand);

            if (result.Suceeded)
                return RedirectToAction(nameof(HomeController.Index), "Home");
            else
            {
                foreach (var msg in result.ErrorMessages)
                    ModelState.AddModelError("", msg);

                return View(model);
            }
        }

        private async Task FillIdentityOptionsViewBag()
        {
            var pwdInfo = await _mediator.Send(new IdentityOptionsQuery());
            ViewBag.PasswordInfo = pwdInfo;
        }
    }
}