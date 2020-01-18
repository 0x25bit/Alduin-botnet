using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alduin.Logic.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Alduin.Web.Controllers
{
    public class StaticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaticsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> BotList()
        {
            var query = new GetBotListQuery();
            var bot = await _mediator.Send(query);
            return Json(bot);
        }
    }
}