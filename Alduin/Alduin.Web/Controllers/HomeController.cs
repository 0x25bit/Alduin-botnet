using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Alduin.Logic.Mediator.Commands;
using Alduin.Logic.Mediator.Queries;
using Alduin.Web.Models;

namespace Alduin.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(IMediator mediator, IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            ViewData["Welcome"] = _localizer["Welcome"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Test(int id)
        {
            var result = await _mediator.Send(new DeleteUserCommand
            {
                UserId = id
            });

            return Json(result);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult SetLanguage(string culture, string returnUrl = "~/")
        {
            culture = culture ?? "en-US";

            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1)
                }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
