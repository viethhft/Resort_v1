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
            ViewData["user"] = JsonConvert.DeserializeObject<Models.User>(HttpContext.Session.GetString("user"));
            ViewData["userDetail"] = JsonConvert.DeserializeObject<UserDetail>(HttpContext.Session.GetString("userDetail"));
            return View();
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

        [Route("Admin/ForgotPassword")]
        public IActionResult ForGotPassword()
        {
            return View();
        }

        [Route("Admin/CreateResort")]
        public IActionResult CreateResort()
        {
            ViewData["user"] = JsonConvert.DeserializeObject<Models.User>(HttpContext.Session.GetString("user"));
            ViewData["userDetail"] = JsonConvert.DeserializeObject<UserDetail>(HttpContext.Session.GetString("userDetail"));
            return View();
        }
        [Route("Admin/ListResort")]
        public IActionResult ListResort()
        {
            ViewData["user"] = JsonConvert.DeserializeObject<Models.User>(HttpContext.Session.GetString("user"));
            ViewData["userDetail"] = JsonConvert.DeserializeObject<UserDetail>(HttpContext.Session.GetString("userDetail"));
            return View();
        }




    }
}
