using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeAdminController : Controller
    {
        [Route("Admin/Home")]
        public IActionResult IndexAdmin()
        {
            var user = JsonConvert.DeserializeObject<Models.User>(HttpContext.Session.GetString("user"));
            ViewData["userDetail"] = JsonConvert.DeserializeObject<UserDetail>(HttpContext.Session.GetString("userDetail"));
            return View(user);
        }
        [Route("Admin/Login")]
        public IActionResult AdminLoginAccount()
        {
            return View();
        }

        [Route("Admin/Sign")]
        public IActionResult AdminSignAccount()
        {
            return View();
        }
    }
}
