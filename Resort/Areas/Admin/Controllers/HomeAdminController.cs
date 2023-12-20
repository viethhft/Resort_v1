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

        [Route("Admin/Login")]
        public IActionResult AdminLoginAccount()
        {
            return View();
        }
    }
}
