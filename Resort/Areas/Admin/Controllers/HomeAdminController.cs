using Microsoft.AspNetCore.Mvc;

namespace Resort.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeAdminController : Controller
    {
        [Route("Admin/Home")]
        public IActionResult IndexAdmin()
        {
            return View();
        }
    }
}
