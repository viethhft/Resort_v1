using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountAdminController : Controller
    {
        User user = null;
        private readonly IUserSer _userSer;
        private readonly IUserDetailSer _userDetailRepo;
        public AccountAdminController(IUserSer userSer, IUserDetailSer userDetailSer)
        {
            _userSer = userSer;
            _userDetailRepo = userDetailSer;
        }

        public async Task<IActionResult> Index(string email, string pass)
        {
            var user = await _userSer.GetUserByEmailAndPass(email, pass);
            if (user != null)
            {
                ViewData["userDetail"] = await _userDetailRepo.GetUserDetailByIdUser(user.IdUser);
                var userIn4 = JsonConvert.SerializeObject(await _userSer.GetUserById(user.IdUser));
                var userDetailIn4 = JsonConvert.SerializeObject(ViewData["userDetail"]);
                HttpContext.Session.SetString("user", userIn4);
                HttpContext.Session.SetString("userDetail", userDetailIn4);
                return RedirectToAction("IndexAdmin","HomeAdmin",user,"ok");
            }
            else
            {
                return View();
            }
        }
    }
}
