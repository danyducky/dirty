using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Openskill.Helpers.Enums;
using Openskill.Helpers.Filters;

namespace Openskill.Controllers
{
    [Authorize]
    [Menu(MenuItem.Teacher)]
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
