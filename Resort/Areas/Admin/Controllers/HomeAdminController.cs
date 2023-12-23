using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeAdminController : Controller
    {
        private readonly IProvinceSer _provinceSer;
        public HomeAdminController(IProvinceSer provinceSer)
        {
            _provinceSer = provinceSer;
        }

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
        public async Task<IActionResult> CreateResort()
        {
            ViewData["user"] = JsonConvert.DeserializeObject<Models.User>(HttpContext.Session.GetString("user"));
            ViewData["userDetail"] = JsonConvert.DeserializeObject<UserDetail>(HttpContext.Session.GetString("userDetail"));
            ViewBag.ListProvince = await ListProvince();
            return View();
        }

        private async Task<List<SelectListItem>> ListProvince()
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            foreach (var item in await _provinceSer.GetAllProvince())
            {
                SelectListItem selectListItem = new SelectListItem() {
                    Value = item.IdProvince.ToString(),
                    Text=item.Name
                };
                lst.Add(selectListItem);
            }
            return lst;
        }
    }
}
