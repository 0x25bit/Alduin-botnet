using System.Threading.Tasks;
using Alduin.Web.Models.Bot;
using Microsoft.AspNetCore.Mvc;

namespace Alduin.Web.Controllers
{
    public class GateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Regbot(BotRegisterModel model)
        {
            if (!ModelState.IsValid)
                return NotFound();

            return Json("");
        }
    }
}